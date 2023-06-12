using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;
using System.Net;


namespace TP_grupoA_Cine
{
    public partial class Form_Cartelera : Form //Form del Register
    {
        public TransfDelegado TransfEvento_CarteleraBotonera;
        public TransfDelegado TransfEvento_CarteleraLogin;
        public TransfDelegado TransfEvento_CarteleraUsuarioActivo;
        public TransfDelegado TransfEvento_CarteleraPeliculasSalas;

        private int selectedFuncionBuscada;

        Cine cine = Cine.Instancia; // Traer el cine

        public Form_Cartelera()
        {
            InitializeComponent();
            selectedFuncionBuscada = -1;
            label1.Text = cine.usuarioActual().Nombre;
            if (cine.usuarioActual().EsAdmin == false) btnvolver_cartelera.Visible = false;

            foreach (Pelicula p in cine.mostrarPeliculas())
            {
                cbPelicula.Items.Add(p.Nombre.ToString());
            }

            foreach (Funcion f in cine.mostrarFunciones())
            {
                cbCosto.Items.Add(f.Costo.ToString());
            }

            foreach (Sala s in cine.mostrarSalas())
            {
                cbUbicacion.Items.Add(s.Ubicacion.ToString());
            }
        }

        public delegate void TransfDelegado();

        private void btnvolver_cartelera_Click(object sender, EventArgs e)
        {
            this.TransfEvento_CarteleraBotonera();
        }

        private void btnmostrar_funciones_Click(object sender, EventArgs e)
        {
            refreshData();
            selectedFuncionBuscada = -1;


        }

        private void refreshData()
        {
            dataGridView1.Rows.Clear();
            //Almacenamos los datos del calendario
            int dia = Convert.ToInt32(monthCalendar1.SelectionStart.Day.ToString());
            int mes = Convert.ToInt32(monthCalendar1.SelectionStart.Month.ToString());
            int anio = Convert.ToInt32(monthCalendar1.SelectionStart.Year.ToString());
            double costo = Convert.ToDouble(cbCosto.SelectedItem);
            DateTime fechaFuncion = new DateTime(anio, mes, dia);


            List<Funcion> funcionesFiltradas =  cine.mostrarFuncionesFiltradas(Convert.ToString(cbPelicula.SelectedItem), Convert.ToString(cbUbicacion.SelectedItem), costo, fechaFuncion);

            foreach (Funcion funcion in funcionesFiltradas)
            {
                string url = funcion.MiPelicula.Poster.ToString();
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(url);
                MemoryStream ms = new MemoryStream(bytes);
                dataGridView1.Rows.Add(funcion.ID.ToString(), funcion.MiPelicula.Nombre.ToString(), funcion.MiSala.Ubicacion.ToString(),
                                               funcion.Fecha.ToString(), funcion.Costo.ToString(), Image.FromStream(ms));
                funcion_seleccionada.Text = "";
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dataGridView1[0, e.RowIndex].Value.ToString();
            string MiPelicula = dataGridView1[1, e.RowIndex].Value.ToString();
            string MiSala = dataGridView1[2, e.RowIndex].Value.ToString();
            string Fecha = dataGridView1[3, e.RowIndex].Value.ToString();
            string Costo = dataGridView1[4, e.RowIndex].Value.ToString();
            funcion_seleccionada.Text = ID;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.TransfEvento_CarteleraLogin();
        }


        private void btncomprar_Click(object sender, EventArgs e)
        {
            string mensaje;
            if (funcion_seleccionada.Text == "" || funcion_seleccionada.Text == null)
            {
                MessageBox.Show("Debe seleccionar una FUNCION", "ERROR");
            }
            else
            {
                mensaje = cine.comprarEntrada(cine.usuarioActual().ID, Convert.ToInt32(funcion_seleccionada.Text), Convert.ToInt32(cantidadentradas.Value));
                MessageBox.Show(mensaje, "COMPRA EXITOSA!");
            }
        }

        public void btnmodificarusuario_Click(object sender, EventArgs e)
        {
            this.TransfEvento_CarteleraUsuarioActivo();
        }

        private void button1_Click(object sender, EventArgs e) //Boton de carga de credito
        {
            cine.cargarCredito(cine.usuarioActual().ID, 500);
            MessageBox.Show("SALDO ACTUAL: " + cine.usuarioActual().Credito, "CARGA EXITOSA!");
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            this.TransfEvento_CarteleraPeliculasSalas();
        }
    }
}