using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP_grupoA_Cine
{
    public partial class Form_Registro : Form       
    {
        Cine cine = Cine.Instancia; // Traer el cine
        public Form_Registro()
        {
            InitializeComponent();
        }

        //Registro del usuario
     /*   private void button1_Click(object sender, EventArgs e) // Accion del Boton Register // Resgistra el usuario
        { 
            string nombre = tbNombre.Text;
            string dni = tbDNI.Text;
            string mail = tbMail.Text;
            string apellido = textBox4.Text;
            DateTime fechaNacimiento = textBox5.Text;
            string password = tbContraseña.Text;
            bool esAdmin = textBox7.Text;

            if (nombre != null && nombre != "" && password != null && password != "" && dni != null && dni != "" && mail != null && mail != "" && apellido != null && apellido != "" && fechaNacimiento != null && esAdmin != null)
            {
                //Registro Usuario

                if (cine.altaUsuario(dni, nombre, apellido, mail, password, fechaNacimiento, esAdmin)) //Dni tira error por el textbox no permite string
                
                    MessageBox.Show("Registrado con éxito"); 
            
            }
            else
                MessageBox.Show("Debe completar los campos");
        }*/


    }
}
