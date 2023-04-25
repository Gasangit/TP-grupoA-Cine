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


namespace TP_grupoA_Cine
{
    public partial class AMB_Funciones : Form //Form de funciones
    {

        public TransfDelegado TransfEvento;

        Cine cine = Cine.Instancia; // Traer el cine

        public AMB_Funciones()
        {
            InitializeComponent();
        }

        public delegate void TransfDelegado();

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
