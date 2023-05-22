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
    public partial class Form_Usuario_Funciones : Form
    {
        public TransfDelegado TransfEvento_UsuarioFuncion_UsuarioActual;
        public TransfDelegado TransfEvento_UsuarioFuncion_Volver_UsuarioActual;
        private Cine cine;
        private int selectedUserFuncion;
        private string idUsuarioCompra;
        private string cantCompra;
        private string monto;
        private string funcion;

        public Form_Usuario_Funciones()
        {
            InitializeComponent();
            cine = Cine.Instancia;
            selectedUserFuncion = -1;
        }

        private void btnmostrarFunciones_Click(object sender, EventArgs e)
        {
            refreshData();
            selectedUserFuncion = -1;
        }


        private void refreshData()
        {
            dataGridView1.Rows.Clear();

            foreach (UsuarioFuncion uf in cine.mostrarUsuarioFuncion())
            {
                foreach (Funcion f in cine.mostrarFunciones())
                {
                    if (uf.idFuncion == f.ID && uf.idUsuario == cine.usuarioActual().ID)
                    {
                        dataGridView1.Rows.Add(uf.idUsuario.ToString(), uf.idFuncion.ToString(), uf.cantidadCompra.ToString(), f.Fecha.ToString(), f.MiPelicula.Nombre.ToString(), f.MiSala.Ubicacion.ToString(), (f.Costo * uf.cantidadCompra).ToString());
                    }
                }

            }
        }


        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.TransfEvento_UsuarioFuncion_Volver_UsuarioActual();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Selecciona una funcion del gird para devolver entrada
        {

            idUsuarioCompra = dataGridView1[0, e.RowIndex].Value.ToString();
            funcion = dataGridView1[1, e.RowIndex].Value.ToString();
            cantCompra = dataGridView1[2, e.RowIndex].Value.ToString();
            monto = dataGridView1[6, e.RowIndex].Value.ToString();

            funcion_seleccionada.Text = funcion; //Texbox que almacena la funcin seleccionada para devolver

        }

        private void button1_Click(object sender, EventArgs e) //Boton para devolver entradas
        {
            string mensaje = "";


            if (funcion_seleccionada.Text == "" || funcion_seleccionada.Text == null)
            {
                MessageBox.Show("Seleccione una funcion", "ERROR");

            }
            else if (cantidadentradas.Value == 0 || cantidadentradas.Value == null)
            {
                MessageBox.Show("Debe indicar cantidad a devolver", "ERROR");
            }
            else
            {
                mensaje = cine.devolverEntrada(Convert.ToInt32(idUsuarioCompra), Convert.ToInt32(funcion), Convert.ToInt32(cantidadentradas.Value));
                
            }

            MessageBox.Show(mensaje);
            refreshData();

        }
        public delegate void TransfDelegado();
    }
}

