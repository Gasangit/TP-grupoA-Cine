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

namespace TP_grupoA_Cine
{

    public partial class ABM_Pelicula : Form    //Form de peliculas
    {
        public TransfDelegado TransfEvento;
        private int selectedPelicula;

        Cine cine = Cine.Instancia;
        public ABM_Pelicula()
        {

            InitializeComponent();
            selectedPelicula = -1;

        }

        public delegate void TransfDelegado();

        private void button4_Click(object sender, EventArgs e) // Agregar Boton 4 en el DESIGNER (Mostrar datos)
        {
            refreshData();

            selectedPelicula = -1;


        }

        public void refreshData()
        {
            dataGridView1.Rows.Clear();

            foreach (Pelicula p in cine.mostrarPeliculas())
                dataGridView1.Rows.Add(p.ToString());



            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";//Tira error porque faltan texts


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellCancelEventArgs e)
        {
            string ID = dataGridView1[0, e.RowIndex].Value.ToString();
            string nombre = dataGridView1[1, e.RowIndex].Value.ToString();
            string sinopsis = dataGridView1[2, e.RowIndex].Value.ToString();
            string poster = dataGridView1[3, e.RowIndex].Value.ToString();
            string duracion = dataGridView1[5, e.RowIndex].Value.ToString();
            selectedPelicula = int.Parse(ID);
            textBox1.Text = ID;
            textBox2.Text = nombre;
            textBox3.Text = sinopsis;
            textBox4.Text = poster;
            textBox5.Text = duracion;

        }

        //Modifcar Pelicula
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedPelicula != 1)
            {
                if (cine.modificarPelicula(selectedPelicula, textBox2.Text, textBox3.Text, int.Parse(textBox5.Text)))
                    MessageBox.Show("Pelicula Modificada con éxito");

                else
                    MessageBox.Show("Error al modificar");
            }
            else
                MessageBox.Show("Debe seleccionar una pelicula");

        }

        //Eliminar Pelicula
        public void button3_Click(object name, EventArgs e)
        {
            if (selectedPelicula != -1)
            {
                cine.bajaPelicula(selectedPelicula);
                MessageBox.Show("Eliminado con éxito");

            }
            else
                MessageBox.Show("Debe seleccionar una pelicula");

        }

        //Alta de pelicula
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || textBox5.Text == null)
                MessageBox.Show("Se deben completar los campos");
            else
                if (cine.altaPelicula(textBox1.Text, textBox4.Text, int.Parse(textBox2.Text)))
                MessageBox.Show("La pelicula se agrego con éxito");
            else
                MessageBox.Show("Error al agregar la pelicula");

        }




    }
}
