using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TP_grupoA_Cine
{
    public partial class AMB_Funciones : Form //Form de funciones
    {
        private int selectedFuncion;
        public TransfDelegado TransfEvento;

        Cine cine = Cine.Instancia; // Traer el cine

        public AMB_Funciones()
        {
            InitializeComponent();
            selectedFuncion = -1;
        }

        public delegate void TransfDelegado();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //Muestra los datos
        private void button1Click(object sender, EventArgs e)
        {
            refreshData();
            selectedFuncion = -1;

        }

        private void refreshData()
        {
            dataGridView1.Rows.Clear();

            foreach (Funcion f in cine.mostrarFunciones())
                dataGridView1.Rows.Add(false.ToString());


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";


        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dataGridView1[0, e.RowIndex].Value.ToString();
            string MiPelicula = dataGridView1[0, e.RowIndex].Value.ToString();
            string Misala = dataGridView1[0, e.RowIndex].Value.ToString();
            string Costo = dataGridView1[0, e.RowIndex].Value.ToString();
            string Fecha = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox1.Text = ID;
            textBox2.Text = Misala;
            textBox3.Text = MiPelicula;
            textBox4.Text = Fecha;
            textBox5.Text = Costo;
            selectedFuncion = int.Parse(ID);

        }
        //Modifica la funcion
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedFuncion != -1)
            {
                if (cine.modificarFuncion(selectedFuncion, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text))
                    MessageBox.Show("Modificado con éxito");
                else
                    MessageBox.Show("Error al modificar");

            }
            else
                MessageBox.Show("Debe seleccionar una funcion");

        }
        */
        //Elimina la funcion
        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedFuncion != -1)
            {
                cine.bajaFuncion(selectedFuncion);
                MessageBox.Show("Eliminado con éxito");

            }
            else
                MessageBox.Show("Debe seleccionar una funcion");

        }

        //Agrega una Funcion
        /*
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || textBox5.Text == null)
                MessageBox.Show("Debe completar los datos para agregar");
            else
                if (cine.altaFuncion(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text))
                MessageBox.Show("Agregado con éxito");
            else
                MessageBox.Show("Error al agregar la funcion");
        }
        */
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
