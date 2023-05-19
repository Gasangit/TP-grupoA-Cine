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
        private string compra;
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
            /*  foreach (List<string> UsuarioFuncion in cine.obtenerFuncionesUsuario())
                  dataGridView1.Rows.Add(UsuarioFuncion.ToArray());
            */
            foreach (UsuarioFuncion uf in cine.mostrarUsuarioFuncion())
            {
                foreach (Funcion f in cine.mostrarFunciones())
                {
                    if (uf.idFuncion == f.ID && uf.idUsuario == cine.usuarioActual().ID)
                    {
                        dataGridView1.Rows.Add(uf.idCompra.ToString(), uf.idUsuario.ToString(), uf.idFuncion.ToString(), uf.cantidadCompra.ToString(), f.Fecha.ToString(), f.MiPelicula.Nombre.ToString(), f.MiSala.Ubicacion.ToString(), (f.Costo * uf.cantidadCompra).ToString());
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

            string idCompra = dataGridView1[0, e.RowIndex].Value.ToString();
            funcion = dataGridView1[2, e.RowIndex].Value.ToString();
            compra = dataGridView1[3, e.RowIndex].Value.ToString();
            monto = dataGridView1[7, e.RowIndex].Value.ToString();
            funcion_seleccionada.Text = idCompra;

        }

        private void button1_Click(object sender, EventArgs e) //Boton para devolver entradas
        {
            // refreshData();
            // selectedUserFuncion = -1;
            string mensaje = "";

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
                if (cantidadentradas.Value <= Convert.ToInt32(compra))
                {
                    if (cantidadentradas.Value == Convert.ToInt32(compra))
                    {
                        mensaje = cine.eliminarEntrada(Convert.ToInt32(funcion_seleccionada.Text), cine.usuarioActual().ID, Convert.ToInt32(funcion), Convert.ToInt32(compra), Convert.ToDouble(monto));
                        MessageBox.Show(mensaje);
                        refreshData();
                    }
                    else if (cantidadentradas.Value < Convert.ToInt32(compra))
                    {
                        mensaje = cine.devolverEntrada(Convert.ToInt32(funcion_seleccionada.Text), cine.usuarioActual().ID, Convert.ToInt32(funcion), Convert.ToInt32(compra), Convert.ToDouble(monto));
                        MessageBox.Show(mensaje);
                        refreshData();
                    }
                    else
                    {
                        MessageBox.Show("No puede solicitar devolucion por una cantidad mayor al a comprada", "ERROR");
                    }

                }
            }

        }
        public delegate void TransfDelegado();
    }
}

