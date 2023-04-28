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
        public DelegadoSalas TransfEvento_SalaBotonera;

        Cine cine = Cine.Instancia; // Traer el cine
        public ABM_Salas()
        {
            InitializeComponent();
            selectedSala = -1;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnmostrar_sala_Click(object sender, EventArgs e) // muentra los datos
        {
            refreshData();
            selectedSala = -1;
        }

        public void refreshData() // recargar los datos en la vista
        {
            dataGridView1.Rows.Clear();

            foreach (Sala s in cine.mostrarSalas())
                dataGridView1.Rows.Add(s.ToString());


            ubicacionsala_text.Text = "";
            idsala_text.Text = "";
            capacidadsala_text.Text = "";

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //tabla con la informacion
        {
            string ID = dataGridView1[0, e.RowIndex].Value.ToString();
            string ubicacion = dataGridView1[1, e.RowIndex].Value.ToString();
            string capacidad = dataGridView1[2, e.RowIndex].Value.ToString();
            idsala_text.Text = ID;
            ubicacionsala_text.Text = ubicacion;
            capacidadsala_text.Text = capacidad;
            selectedSala = int.Parse(ID);
        }

        private void btnmodificar_sala_Click(object sender, EventArgs e) //modificar la sala
        {
            if (selectedSala != -1)
            {
                if (cine.modificacionSala(selectedSala, ubicacionsala_text.Text, int.Parse(capacidadsala_text.Text)))
                    MessageBox.Show("Modificado con éxito");
                else
                    MessageBox.Show("Error al modificar la sala");
            }
            else
                MessageBox.Show("Debe seleccionar una sala");

        }

        private void btnbaja_sala_Click(object sender, EventArgs e) //dar de baja la sala
        {
            if (selectedSala != -1)
            {
                cine.bajaSala(selectedSala);
                MessageBox.Show("Eliminado con éxito");

            }
            else
                MessageBox.Show("Debe seleccionar una sala");

        }

        private void btnalta_sala_Click(object sender, EventArgs e) //dar de alta una sala
        {
            if (capacidadsala_text.Text == "" || ubicacionsala_text.Text == "" || capacidadsala_text.Text == null || ubicacionsala_text.Text == null)
                MessageBox.Show("Debe completar los datos para agregar");
            else
                if (cine.altaSala(ubicacionsala_text.Text, int.Parse(capacidadsala_text.Text)))
                MessageBox.Show("Agregado con éxito");
            else
                MessageBox.Show("Error al agregar una sala");
        }

        private void btnvolver_salas_Click(object sender, EventArgs e)
        {
            this.TransfEvento_SalaBotonera();
        }

        public delegate void DelegadoSalas();
    }
}
