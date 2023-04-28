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
        public DelegadoFuncion TransfEvento_FuncionBotonera;

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
            string Misala = dataGridView1[1, e.RowIndex].Value.ToString();
            string MiPelicula = dataGridView1[2, e.RowIndex].Value.ToString();
            string Fecha = dataGridView1[3, e.RowIndex].Value.ToString();
            string Costo = dataGridView1[4, e.RowIndex].Value.ToString();
            idfuncion_text.Text = ID;
            salafuncion_text.Text = Misala;
            peliculafuncion_text.Text = MiPelicula;
            fechafuncion_text.Text = Fecha;
            costofuncion_text.Text = Costo;
            selectedFuncion = int.Parse(ID);

        }
        //Modifica la funcion

        /* private void btnmodificar_funcion_Click(object sender, EventArgs e)
         {
             if (selectedFuncion != -1)
             {


                 if (cine.modificarFuncion(selectedFuncion, salafuncion_text.Text, peliculafuncion_text.Text, DateTime.Parse(fechafuncion_text.Text), Convert.ToDouble(costofuncion_text.Text)))
                     MessageBox.Show("Modificado con éxito");
                 else
                     MessageBox.Show("Error al modificar");

             }
             else
                 MessageBox.Show("Debe seleccionar una funcion");

         }*/


        private void btnmodificar_funcion_Click(object sender, EventArgs e)
        {
            if (selectedFuncion != -1)
            {
                string sala = salafuncion_text.Text;
                string pelicula = peliculafuncion_text.Text;
                DateTime fecha = DateTime.Parse(fechafuncion_text.Text);
                double costo = Convert.ToDouble(costofuncion_text.Text);

                if (cine.modificarFuncion(selectedFuncion, sala, pelicula, fecha, costo))
                {
                    MessageBox.Show("Modificado con éxito");
                }
                else
                {
                    MessageBox.Show("Error al modificar");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una funcion");
            }
        }



        //Elimina la funcion
        private void btnbaja_funcion_Click(object sender, EventArgs e)
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

       private void btnalta_funcion_Click(object sender, EventArgs e)
        {
          /*  if (costofuncion_text.Text == "" || fechafuncion_text.Text == "" || peliculafuncion_text.Text == "" || salafuncion_text.Text == "" || costofuncion_text.Text == null || fechafuncion_text.Text == null || peliculafuncion_text.Text == null || salafuncion_text.Text == null)
                MessageBox.Show("Debe completar los datos para agregar");
            else
                if (cine.altaFuncion(costofuncion_text.Text, DateTime.Parse(fechafuncion_text.Text), peliculafuncion_text.Text, salafuncion_text.Text))
                MessageBox.Show("Agregado con éxito");
            else
                MessageBox.Show("Error al agregar la funcion");*/
        }

        private void btnvolver_funcion_Click(object sender, EventArgs e)
        {
            this.TransfEvento_FuncionBotonera();
        }

        public delegate void DelegadoFuncion();
    }
}
