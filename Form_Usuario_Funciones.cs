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
                foreach (Usuario us in cine.mostrarUsuarios())
                {
                    foreach (Funcion f in cine.mostrarFunciones())
                    {
                        if (uf.idUsuario == cine.usuarioActual().ID && uf.idFuncion == f.ID) //traemos el usuarioactual o el ID de usuario????
                        {
                            dataGridView1.Rows.Add(uf.idUsuario.ToString(), uf.idFuncion.ToString(), uf.cantidadCompra.ToString(), f.Fecha.ToString(), f.MiPelicula.Nombre.ToString(), f.MiSala.Ubicacion.ToString(), (f.Costo * uf.cantidadCompra).ToString());
                        }
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

            funcion = dataGridView1[1, e.RowIndex].Value.ToString();
            cantCompra = dataGridView1[2, e.RowIndex].Value.ToString();
            monto = dataGridView1[6, e.RowIndex].Value.ToString();

            funcion_seleccionada.Text = funcion; //Texbox que almacena la funcin seleccionada para devolver

        }

        private void button1_Click(object sender, EventArgs e) //Boton para devolver entradas
        {
            // refreshData();
            // selectedUserFuncion = -1;
           // string mensaje = "";

            //Logica de devolucion pasar a CINE



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
                cine.devolverEntrada(cine.usuarioActual().ID, Convert.ToInt32(funcion), Convert.ToInt32(cantCompra), Convert.ToDouble(monto));

                //if (cantidadentradas.Value <= Convert.ToInt32(compra))
                //{
                //    if (cantidadentradas.Value == Convert.ToInt32(compra))
                //    {
                //        mensaje = cine.eliminarEntrada(cine.usuarioActual().ID, Convert.ToInt32(funcion), Convert.ToInt32(compra), Convert.ToDouble(monto));
                //        MessageBox.Show(mensaje);
                //        refreshData();
                //    }
                //    else if (cantidadentradas.Value < Convert.ToInt32(compra))
                //    {
                //        mensaje = cine.devolverEntrada(cine.usuarioActual().ID, Convert.ToInt32(funcion), Convert.ToInt32(compra), Convert.ToDouble(monto));
                //        MessageBox.Show(mensaje);
                //        refreshData();
                //    }
                //    else
                //    {
                //        MessageBox.Show("No puede solicitar devolucion por una cantidad mayor al a comprada", "ERROR");
                //    }

                //}

            }

        }
        public delegate void TransfDelegado();
    }
}

