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
    public partial class ABM_Usuarios : Form //Form de Usuarios
    {
        private Cine cine;
        private int selectedUser;
        public ABM_Usuarios()
        {
            InitializeComponent();
            cine = Cine.Instancia;
            selectedUser = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refreshData();
            selectedUser = -1;
        }

        private void refreshData()
        {
            //borro los datos
            dataGridView1.Rows.Clear();
            //agrego lo nuevo
            foreach (Usuario u in cine.mostrarUsuarios())
                dataGridView1.Rows.Add(u.ToString());

            //borro los datos en los text box
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string ID = dataGridView1[0, e.RowIndex].Value.ToString();
            string nombreUser = dataGridView1[1, e.RowIndex].Value.ToString();
            string apellidoUser = dataGridView1[2, e.RowIndex].Value.ToString();
            string dniUser = dataGridView1[3, e.RowIndex].Value.ToString();
            string mailUser = dataGridView1[4, e.RowIndex].Value.ToString();
            string passUser = dataGridView1[5, e.RowIndex].Value.ToString();
            string fecNacUser = dataGridView1[6, e.RowIndex].Value.ToString();
            string adminUser = dataGridView1[7, e.RowIndex].Value.ToString();
            string bloqUser = dataGridView1[8, e.RowIndex].Value.ToString();

            textBox1.Text = nombreUser;
            textBox2.Text = mailUser;
            textBox3.Text = dniUser;
            textBox4.Text = apellidoUser;
            textBox5.Text = passUser;
            textBox7.Text = fecNacUser;
            comboBox1.Text = adminUser;
            comboBox2.Text = bloqUser;
            selectedUser = int.Parse(ID);
        }

        private bool button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox2.Text == null || textBox3.Text == null ||
                textBox1.Text == "" || textBox4.Text == "" || textBox1.Text == null || textBox4.Text == null ||
                textBox5.Text == "" || textBox7.Text == "" || textBox5.Text == null || textBox7.Text == null)
            {
                MessageBox.Show("Debe completar los datos para agregar");
                return false;
            }

            else
            {
                if (cine.altaUsuario(int.Parse(textBox3.Text), textBox1.Text, textBox4.Text, textBox2.Text, textBox5.Text, DateTime.Parse(textBox7.Text), true))
                {
                    MessageBox.Show("Agregado con éxito");
                    return true;
                }
                else
                {
                    MessageBox.Show("Problemas al agregar");
                    return false;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
