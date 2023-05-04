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

        public Form_Usuario_Funciones()
        {
            InitializeComponent();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.TransfEvento_UsuarioFuncion_Volver_UsuarioActual();
        }

        public delegate void TransfDelegado();
    }
}
