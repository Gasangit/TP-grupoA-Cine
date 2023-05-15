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
            foreach (Funcion funcion in cine.usuarioActual().MisFunciones)
                dataGridView1.Rows.Add(funcion.ToStringFunciones());
        }


        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.TransfEvento_UsuarioFuncion_Volver_UsuarioActual();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //Selecciona una funcion del gird para devolver entrada
        {
            string idFuncion = dataGridView1[0, e.RowIndex].Value.ToString();

            funcion_seleccionada.Text = idFuncion;

        }

        private void button1_Click(object sender, EventArgs e) //Boton para devolver entradas
        {
            if (funcion_seleccionada.Text == "" || funcion_seleccionada.Text == null)
            {
                MessageBox.Show("Seleccione una funcion", "ERROR");

            }
            else //HAY QUE VALIDAR QUE LA CANTIDAD SEA IGUAL O MENOR A LA COMPRADA
            {
                cine.devolverEntrada(cine.usuarioActual().ID, Convert.ToInt32(funcion_seleccionada.Text), Convert.ToInt32(cantidadentradas.Value));
                MessageBox.Show("Se ha reintegrado su crédito" + cine.usuarioActual().Credito, "DEVOLUCION EXITOSA");
                refreshData();
            }


        }

        public delegate void TransfDelegado();
    }
}
