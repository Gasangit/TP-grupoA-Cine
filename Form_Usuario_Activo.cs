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
            Usuario u = cine.usuarioActual();

            if (u != null)
            {
                tbId.Text = u.ID.ToString();
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

        public void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != null && tbNombre.Text != "" && tbContrasenia.Text != null && tbContrasenia.Text != "" && Convert.ToInt32(tbDNI.Text) != 0 && tbDNI.Text != null && tbEmail.Text != null && tbEmail.Text != "" && tbApellido.Text != null && tbApellido.Text != "")
            {

                string ID = tbId.Text;
                selectedUserActive = int.Parse(ID);
                string nombre = tbNombre.Text;
                int dni = Convert.ToInt32(tbDNI.Text);
                string mail = tbEmail.Text;
                string apellido = tbApellido.Text;
                int dia = Convert.ToInt32(mcNacimiento.SelectionStart.Day.ToString());
                int mes = Convert.ToInt32(mcNacimiento.SelectionStart.Month.ToString());
                int anio = Convert.ToInt32(mcNacimiento.SelectionStart.Year.ToString());
                DateTime fechaNacimiento = new DateTime(anio, mes, dia);
                string password = tbContrasenia.Text;


                if (selectedUserActive != -1)// Modifica al usuario
                {
                    if (cine.modificacionUsuarioActual(selectedUserActive, tbEmail.Text, tbContrasenia.Text, tbNombre.Text, tbApellido.Text, Convert.ToInt32(tbDNI.Text), fechaNacimiento))

                        MessageBox.Show("Modificado con éxito", "OK");
                    else
                        MessageBox.Show("Error al modificar", "ERROR");
                }
            }
            else
                MessageBox.Show("Completar los campos", "ERROR");
        }

        private void btnCargar_Click(object sender, EventArgs e) //Boton para cargar credito
        {
            //Sumar credito del monto ingresado en montoCarga (TextBox)
            if(montoCarga.Text != null && montoCarga.Text != "")
            {
                int credito = Convert.ToInt32(montoCarga.Text);
                if (credito > 0)
                {
                    cine.cargarCredito(cine.usuarioActual().ID, credito);
                    MessageBox.Show("SALDO ACTUAL: " + cine.usuarioActual().Credito, "CARGA EXITOSA");
                    refreshData();
                }
                else
                {
                    MessageBox.Show("Ingrese un monto a cargar mayor a 0", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un monto a cargar", "ERROR");
            }
            
            
        }
    }
}
