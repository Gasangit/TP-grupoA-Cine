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
        public DelegadoRegistro TransfEvento_Registrarse;

        public Form_Registro()
        {
            InitializeComponent();
        }

        //Registro del usuario
        private void btnRegistrarse_Click(object sender, EventArgs e) // Accion del Boton Register // Resgistra el usuario
        {
            Registrarse();
            this.TransfEvento_Registrarse();
        }

        public void Registrarse()
        {
            string nombre = tbNombre.Text;
            int dni = Convert.ToInt32(tbDNI.Text);
            string mail = tbMail.Text;
            string apellido = tbApellido.Text;
            int dia = Convert.ToInt32(monthCalendar1.SelectionStart.Day.ToString());
            int mes = Convert.ToInt32(monthCalendar1.SelectionStart.Month.ToString());
            int anio = Convert.ToInt32(monthCalendar1.SelectionStart.Year.ToString());
            DateTime fechaNacimiento = new DateTime(anio, mes, dia);
            //DateTime fechaNacimiento = new DateTime(dia, mes, anio); //este casteo hay que cambiarlo. Tenemos que fomar un fecha.
            string password = tbContraseña.Text;
            bool esAdmin = false; //Un usuario que se registra por defecto NO es admin. 
            bool bloqueado = false;

            //if (cbEsAdmin.Text.ToLower() == "si") esAdmin = true;

            if (nombre != null && nombre != "" && password != null && password != "" && dni != 0 && dni != 0 && mail != null && mail != "" && apellido != null && apellido != "" && fechaNacimiento.Year != 0) //quité la comprobación del admin porque al ser combobox simpre vamos a tener un valor
            {
                //Registro Usuario

                if (tbDNI.Text.Length != 8 && tbDNI.Text.Length != 7)

                {
                    MessageBox.Show("Difiere la cantidad de digitos en el DNI. Deben ser 8 o 7 digitos");
                }
                else
                {
                    if (cine.altaUsuario(dni, nombre, apellido, mail, password, fechaNacimiento, esAdmin, bloqueado))
                    {
                        MessageBox.Show("Registrado con éxito", "REGISTRO EXITOSO");
                    }
                    else
                    {
                        MessageBox.Show("Problemas al agregar o DNI ya existente", "ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos", "ERROR");
            }
        }

        public delegate void DelegadoRegistro();
    }
}
