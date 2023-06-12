using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_grupoA_Cine
{
    public partial class Form_PeliculasSalas : Form
    {
        private int selectedSala;
        private int selectedPelicula;
        public DelegadoPeliculaSalas TransfEvento_VolverCartelera;

        Cine cine = Cine.Instancia;
        public Form_PeliculasSalas()
        {
            InitializeComponent();
            selectedSala = -1;
            selectedPelicula = -1;

        }

        private void btnMostrar_Click(object sender, EventArgs e) //Boton para traer datos de salas o peliculas
        {
            refreshData();
            selectedSala = -1;
            selectedPelicula = -1;
        }

        public void refreshData() // recargar los datos en la vista dependiendo la pestaña
        {
            dataGridView1.Rows.Clear();

            dataGridView2.Rows.Clear();

            if (tabControl1.SelectedTab == tabPage1) //Pestaña de salas
            {
                foreach (Sala s in cine.mostrarSalas())
                    dataGridView1.Rows.Add(s.ToString());
            }
            else  //Pestaña Peliculas
            {
                foreach (Pelicula p in cine.mostrarPeliculas())
                {
                    dataGridView2.Rows.Add(p.ToString());
                }
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Tabla de SALAS completa grid Funciones
        {

            dataGridView3.Rows.Clear(); // Limpia el grid de funciones_Salas

            int idSala = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);

            List<Funcion> listaFunciones = cine.mostrarFuncionesXSala(idSala);
            
            foreach(Funcion funcion in listaFunciones)
            {
                dataGridView3.Rows.Add(funcion.ToStringFunciones());
            }
                   
        }


        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Tabla de PELICULAS completa grid funciones
        {
            dataGridView3.Rows.Clear(); //Limpia grid de funciones

            int idPelicula = Convert.ToInt32(dataGridView2[0, e.RowIndex].Value);

            List<Funcion> listaFunciones = cine.mostrarFuncionesXPelicula(idPelicula);

            foreach (Funcion funcion in listaFunciones) 
            {
                dataGridView3.Rows.Add(funcion.ToStringFunciones());
            }           
              
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)

        {
            string idFuncion = dataGridView3[0, e.RowIndex].Value.ToString();
            funcion_seleccionada.Text = idFuncion;
        }

        private void btnVolver_Click(object sender, EventArgs e) //Boton para volver a la cartelera
        {
            this.TransfEvento_VolverCartelera();
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
                MessageBox.Show(mensaje);
            }
        }

        public delegate void DelegadoPeliculaSalas();

    }
}
