using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Diagnostics;

namespace TP_grupoA_Cine
{

    public partial class ABM_Pelicula : Form    //Form de peliculas
    {
        public DelegadoPelicula TransfEvento_PeliculaBotonera;
        private int selectedPelicula;


        Cine cine = Cine.Instancia;
        public ABM_Pelicula()
        {

            InitializeComponent();
            selectedPelicula = -1;

        }

        private void btnmostrarpelicula_Click(object sender, EventArgs e)
        {
            refreshData();

            selectedPelicula = -1;

        }

        public void refreshData()
        {
            dataGridView1.Rows.Clear();


            foreach (Pelicula p in cine.mostrarPeliculas())
            {

                string url = p.Poster.ToString();
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(url);
                MemoryStream ms = new MemoryStream(bytes);
                //nombre, sinopsis, duracion, poster
                dataGridView1.Rows.Add(p.ID.ToString(), p.Nombre.ToString(), p.Sinopsis.ToString(),
                                        p.Duracion.ToString(), Image.FromStream(ms), p.Poster.ToString());
                //dataGridView1.Rows.Add(p.ToString(),Image.FromStream(ms));
            }

            nombre_pelicula.Text = "";
            duracion_pelicula.Text = "";
            sinopsis_pelicula.Text = "";
            id_pelicula.Text = "";
            tbPoster.Text = "";


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // para modificar
        {
            string ID = dataGridView1[0, e.RowIndex].Value.ToString();
            string nombre = dataGridView1[1, e.RowIndex].Value.ToString();
            string sinopsis = dataGridView1[2, e.RowIndex].Value.ToString();
            string duracion = dataGridView1[3, e.RowIndex].Value.ToString();
            string poster = dataGridView1[4, e.RowIndex].Value.ToString();
            string urlposter = dataGridView1[5, e.RowIndex].Value.ToString();
            
            Debug.WriteLine("");
            selectedPelicula = int.Parse(ID);
            id_pelicula.Text = ID;
            nombre_pelicula.Text = nombre;
            sinopsis_pelicula.Text = sinopsis;
            duracion_pelicula.Text = duracion;            
            tbPoster.Text = urlposter;
        }

        //Modificar Pelicula
        private void btnmodificarpelicula_Click(object sender, EventArgs e)
        {
            if (selectedPelicula != -1)
            {
                if (cine.modificarPelicula(selectedPelicula, nombre_pelicula.Text, sinopsis_pelicula.Text, int.Parse(duracion_pelicula.Text), tbPoster.Text))
                {
                    MessageBox.Show("Pelicula Modificada con éxito", "OK");


                }
                else
                {
                    MessageBox.Show("Error al modificar", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una pelicula", "ERROR");
            }
        }

        //Eliminar Pelicula
        public void btnbajapelicula_Click(object name, EventArgs e)
        {
            if (selectedPelicula != -1)
            {
                cine.bajaPelicula(selectedPelicula);
                MessageBox.Show("Eliminado con éxito", "OK");

            }
            else
                MessageBox.Show("Debe seleccionar una pelicula", "ERROR");

        }

        //Alta de pelicula
        private void btnaltapelicula_Click(object sender, EventArgs e)
        {
            if (duracion_pelicula.Text == "" || sinopsis_pelicula.Text == "" || duracion_pelicula.Text == null || sinopsis_pelicula.Text == null)
                MessageBox.Show("Se deben completar los campos", "ERROR");
            else
                if (cine.altaPelicula(nombre_pelicula.Text, sinopsis_pelicula.Text, Convert.ToInt32(duracion_pelicula.Text), tbPoster.Text))
                MessageBox.Show("La pelicula se agrego con éxito", "OK");
            else
                MessageBox.Show("Error al agregar la pelicula", "ERROR");

        }

        private void btnvolver_peliculas_Click(object sender, EventArgs e)
        {
            this.TransfEvento_PeliculaBotonera();
        }


        public delegate void DelegadoPelicula();
    }
}
