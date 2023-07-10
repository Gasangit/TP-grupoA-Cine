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
using System.Diagnostics;

namespace TP_grupoA_Cine
{
    public partial class AMB_Funciones : Form //Form de funciones
    {
        private int selectedFuncion;
        public DelegadoFuncion TransfEvento_FuncionBotonera;
        private string idSala;
        private string idPelicula;


        Cine cine = Cine.Instancia; // Traer el cine

        public AMB_Funciones()
        {
            InitializeComponent();
            selectedFuncion = -1;
        }

        public delegate void TransfDelegado();

        //Muestra los datos
        private void btnmostrar_funcion_Click(object sender, EventArgs e)
        {
            refreshData();
            selectedFuncion = -1;

        }

        private void refreshData()
        {
            dataGridView1.Rows.Clear();

            foreach (Funcion funcion in cine.mostrarFunciones())
                dataGridView1.Rows.Add(funcion.ToString());

            idfuncion_text.Text = "";
            salafuncion_text.Text = "";
            costofuncion_text.Text = "";
            fechafuncion_text.Text = "";
            peliculafuncion_text.Text = "";

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)

        {
            string ID = dataGridView1[0, e.RowIndex].Value.ToString();
            string nombreSala = dataGridView1[1, e.RowIndex].Value.ToString();
            string idSala = dataGridView1[2, e.RowIndex].Value.ToString();
            string nombrePelicula = dataGridView1[3, e.RowIndex].Value.ToString();
            string idPelicula = dataGridView1[4, e.RowIndex].Value.ToString();
            string Fecha = dataGridView1[5, e.RowIndex].Value.ToString();
            string Costo = dataGridView1[6, e.RowIndex].Value.ToString();

            idfuncion_text.Text = ID;

            salafuncion_text.Text = idSala;
            Debug.WriteLine(">>> numero sala : " + idSala);

            peliculafuncion_text.Text = idPelicula;
            Debug.WriteLine(">>> numero pelicula : " + idPelicula);
            fechafuncion_text.Text = Fecha;
            costofuncion_text.Text = Costo;
            selectedFuncion = int.Parse(ID);

            //Este combobox pidio agregarlo en la defensa del tp agregarlo en mvc
            //foreach (Pelicula p in cine.mostrarPeliculas())
            //{
            //    comboBox1.Items.Add(p.Nombre.ToString());
            //}
        }
        //Modifica la funcion

        private void btnmodificar_funcion_Click(object sender, EventArgs e)
        {
            if (selectedFuncion != -1)
            {

                if (cine.modificarFuncion(selectedFuncion, Convert.ToInt32(salafuncion_text.Text), Convert.ToInt32(peliculafuncion_text.Text), DateTime.Parse(fechafuncion_text.Text), double.Parse(costofuncion_text.Text)))
                    MessageBox.Show("Modificado con éxito", "OK");
                else
                    MessageBox.Show("Error al modificar", "ERROR");
            }
            else
                MessageBox.Show("Debe seleccionar una funcion", "ERROR");

        }

        //Elimina la funcion
        private void btnbaja_funcion_Click(object sender, EventArgs e)
        {
            if (selectedFuncion != -1)
            {
                cine.bajaFuncion(selectedFuncion);
                MessageBox.Show("Eliminado con éxito", "OK");

            }
            else
                MessageBox.Show("Debe seleccionar una funcion", "ERROR");
        }

        //Agrega una Funcion

        private void btnalta_funcion_Click(object sender, EventArgs e)
        {

            if (costofuncion_text.Text == "" || fechafuncion_text.Text == "" || costofuncion_text.Text == null || fechafuncion_text.Text == null)
                MessageBox.Show("Debe completar los datos para agregar", "ERROR");
            else if (cine.altaFuncion(Convert.ToInt32(salafuncion_text.Text), Convert.ToInt32(peliculafuncion_text.Text), DateTime.Parse(fechafuncion_text.Text), double.Parse(costofuncion_text.Text)))
                MessageBox.Show("Agregado con éxito", "OK");
            else
                MessageBox.Show("Error al agregar la funcion", "ERROR");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnvolver_funcion_Click(object sender, EventArgs e)
        {
            this.TransfEvento_FuncionBotonera();
        }

        public delegate void DelegadoFuncion();
    }
}
