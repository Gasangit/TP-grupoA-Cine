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


namespace TP_grupoA_Cine
{
    public partial class Form_Cartelera : Form //Form del Register
    {
        public TransfDelegado TransfEvento_CarteleraBotonera;

        Cine cine = Cine.Instancia; // Traer el cine

        public Form_Cartelera()
        {

            InitializeComponent();
            label1.Text = cine.usuarioActual.Nombre;

            foreach (Funcion funcion in cine.mostrarFunciones())
            {
                cbPelicula.Items.Add(funcion.MiPelicula.Nombre);
                cbUbicacion.Items.Add(funcion.MiSala.Ubicacion);
                cbCosto.Items.Add(funcion.Costo);
            }
        }

        public delegate void TransfDelegado();


        private void btnvolver_cartelera_Click(object sender, EventArgs e)
        {
            this.TransfEvento_CarteleraBotonera();
        }

        private void btnmostrar_funciones_Click(object sender, EventArgs e)
        {
            //borro los datos
            dataGridView1.Rows.Clear();

            int dia = Convert.ToInt32(monthCalendar1.SelectionStart.Day.ToString());
            int mes = Convert.ToInt32(monthCalendar1.SelectionStart.Month.ToString());
            int anio = Convert.ToInt32(monthCalendar1.SelectionStart.Year.ToString());

            DateTime fechaFuncion = new DateTime(anio, mes, dia);
            Debug.WriteLine(">>>>> Ubicacion: " + cbUbicacion.SelectedValue.ToString());

            string ubicacionFuncion;
            if (cbUbicacion.SelectedValue.ToString() == null) { ubicacionFuncion = "";}
            else { ubicacionFuncion = cbUbicacion.SelectedValue.ToString(); }

            string peliculaFuncion;
            if (cbPelicula.SelectedValue.ToString() == null) { peliculaFuncion = ""; }
            else { peliculaFuncion = peliculaFuncion = cbPelicula.SelectedValue.ToString(); }
            
            double costoFuncion = Convert.ToDouble(cbCosto.SelectedValue.ToString());

            // fecha, ubicacion, costo, pelicula
            List<Funcion> listaFuncionesFiltro = cine.buscarFuncion(fechaFuncion, ubicacionFuncion, costoFuncion, peliculaFuncion);

            //foreach (Funcion funcion in listaFuncionesFiltro)
            //{
            //dataGridView1.Rows.Add(funcion.ToString());
            int count = -1;
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {//columnas : poster pelicula sala fecha costo
            count++;   
                row.Cells[0].Value = listaFuncionesFiltro[count].MiPelicula.Poster;
                row.Cells[1].Value = listaFuncionesFiltro[count].MiPelicula.Nombre;
                row.Cells[2].Value = listaFuncionesFiltro[count].MiSala.ID;
                row.Cells[3].Value = listaFuncionesFiltro[count].Fecha;
                row.Cells[4].Value = listaFuncionesFiltro[count].Costo;

            if (count == (listaFuncionesFiltro.Count -1)) break;
            }
        }
    }
}
