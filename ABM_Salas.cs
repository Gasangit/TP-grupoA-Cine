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

    public partial class ABM_Salas : Form //Form de Salas
    {
        private int selectedSala;
        Cine cine = Cine.Instancia; // Traer el cine
        public ABM_Salas()
        {
            InitializeComponent();
            selectedSala = -1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
            selectedSala = -1;
        }

        public void refreshData()
        {
            dataGridView1.Rows.Clear();
            foreach (Sala s in cine.mostrarSalas())
                dataGridView1.Rows.Add(s.ToString());


            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dataGridView1[0, e.RowIndex].Value.ToString();
            string ubicacion = dataGridView1[0, e.RowIndex].Value.ToString();
            string capacidad = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox1.Text = ID;
            textBox2.Text = ubicacion;
            textBox4.Text = capacidad;
            selectedSala = int.Parse(ID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedSala != -1)
            {
                if (cine.modificacionSala(selectedSala, textBox2.Text, int.Parse(textBox4.Text)))
                    MessageBox.Show("Modificado con éxito");
                else
                    MessageBox.Show("Error al modificar la sala");
            }
            else
                MessageBox.Show("Debe seleccionar una sala");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedSala != -1)
            {
                cine.bajaSala(selectedSala);
                MessageBox.Show("Eliminado con éxito");

            }
            else
                MessageBox.Show("Debe seleccionar una sala");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox4.Text == "" || textBox2.Text == null || textBox4.Text == null)
                MessageBox.Show("Debe completar los datos para agregar");
            else
                if (cine.altaSala(textBox2.Text, int.Parse(textBox4.Text)))
                MessageBox.Show("Agregado con éxito");
            else
                MessageBox.Show("Error al agregar una sala");
        }


    }
}
