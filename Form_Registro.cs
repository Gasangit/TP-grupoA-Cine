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
    public partial class Form_Registro : Form       
    {
        Cine cine = Cine.Instancia; // Traer el cine
        public Form_Registro()
        {
            InitializeComponent();
        }
    }
}
