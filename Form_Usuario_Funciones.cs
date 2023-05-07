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
            foreach (Funcion funcion in cine.mostrarFunciones())
                dataGridView1.Rows.Add(funcion.ToString());
        }




        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.TransfEvento_UsuarioFuncion_Volver_UsuarioActual();
        }

        public delegate void TransfDelegado();
    }
}
