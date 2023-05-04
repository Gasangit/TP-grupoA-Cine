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
    public partial class Form_Usuario_Activo : Form
    {

        public TransfDelegado TransfEvento_UsuarioActivoCartelera;
        public TransfDelegado TransfEvento_UsuarioActivo_UsuarioFuncion;
        private Cine cine;
        private int selectedUserActive;

        public Form_Usuario_Activo()
        {
            InitializeComponent();
            cine = Cine.Instancia;
            selectedUserActive = -1;
        }

        public delegate void TransfDelegado();

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {

            refreshData();
            selectedUserActive = -1;
        }

        private void refreshData()
        {
            Usuario u = cine.usuarioActual;

            if (u != null) 
            { 
                    tbEmail.Text = u.Mail;
                    tbNombre.Text = u.Nombre;
                    tbApellido.Text = u.Apellido;
                    tbCredito.Text = u.Credito.ToString();
                    tbDNI.Text = u.DNI.ToString();
                    mcNacimiento.SelectionStart = u.FechaNacimiento;
                    mcNacimiento.SelectionEnd = u.FechaNacimiento;
                    tbContrasenia.Text = u.Password;
            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.TransfEvento_UsuarioActivoCartelera(); //Vuelve a cartelera
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            this.TransfEvento_UsuarioActivo_UsuarioFuncion(); //Lleva a form de mis funciones
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            int dni = Convert.ToInt32(tbDNI.Text);
            string mail = tbEmail.Text;
            string apellido = tbApellido.Text;
            int dia = Convert.ToInt32(mcNacimiento.SelectionStart.Day.ToString());
            int mes = Convert.ToInt32(mcNacimiento.SelectionStart.Month.ToString());
            int anio = Convert.ToInt32(mcNacimiento.SelectionStart.Year.ToString());
            DateTime fechaNacimiento = new DateTime(anio, mes, dia);
            string password = tbContrasenia.Text;

            if (selectedUserActive != -1)
            {

                if (nombre != null && nombre != "" && password != null && password != "" && dni != 0 && dni != 0 && mail != null && mail != "" && apellido != null && apellido != "" && fechaNacimiento.Year != 0) //quité la comprobación del admin porque al ser combobox simpre vamos a tener un valor
                {
                    //Update Usuario

                    cine.modificacionUsuarioActual(selectedUserActive, mail, password, nombre, apellido, dni, fechaNacimiento);

                    MessageBox.Show("Registrado con éxito");

                }
                else
                {
                    MessageBox.Show("error al modificar");
                }
            }
        }
    }
}
