using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_grupoA_Cine
{
  //  private int selectedPelicula;
    public partial class ABM_Pelicula : Form    //Form de peliculas
    {
        public TransfDelegado TransfEvento;

        Cine cine = Cine.Instancia;
        public ABM_Pelicula()
        {

            InitializeComponent();
          //  selectedPelicula = -1;

        }

        public delegate void TransfDelegado();

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();

           // selectedPelicula = -1;


        }//id nombre sinopsis poster misfunciones y duracion

        public void refreshData()
        {
            dataGridView1.Rows.Clear();

            foreach (Pelicula p in cine.mostrarPeliculas())
                dataGridView1.Rows.Add(p.ToString());



            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
          //  textBox5.Text = "";
           // textBox6.Text = "";//Tira error por el nombre de los texts


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
            string misFunciones = dataGridView1[4, e.RowIndex].Value.ToString();
            string duracion = dataGridView1[5, e.RowIndex].Value.ToString();
           // selectedPelicula = int.Parse(ID);

        }

      //  private void button2_Click(object sender, EventArgs e)
       // {
         //   if (selectedPelicula != 1)
           // { 
             //   if(cine.modificarPelicula())
            //}

      //  }



    }
}
