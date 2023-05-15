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
    public partial class Form_Login : Form //Form del Login
    {

        public DelegadoLogin TransfEvento_LoginCarteleraBotonera; //evento de login a cartelera o botonera
        public DelegadoLogin TransfEvento_LoginRegistro;       //evento de login a registro

        Cine cine = Cine.Instancia;
        public Form_Login()
        {

            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e) //Registrarse
        {
            this.TransfEvento_LoginRegistro(); //evento de login a registro
        }

        private void button2_Click(object sender, EventArgs e) //Login
        {
            string mail = textBox1.Text;
            string password = textBox2.Text;
            if (mail != null && mail != "" && password != null && password != "")
            {
                if (cine.iniciarSesion(mail, password))
                    this.TransfEvento_LoginCarteleraBotonera(); //evento de login a cartelera o botonera                                  
                else
                    switch (cine.intentos(mail))
                    {
                        case 0:
                            MessageBox.Show("Por favor ingresar un usuario correcto", "ERROR");
                            break;
                        case 1:
                            MessageBox.Show("1er intento, contraseña incorrecta", "CUIDADO");
                            break;
                        case 2:
                            MessageBox.Show("2do intento, contraseña incorrecta", "CUIDADO");
                            break;
                        case 3:
                            MessageBox.Show("3er intento, contraseña incorrecta", "CUIDADO");
                            break;
                        default:
                            MessageBox.Show("Usted a sido bloqueado, debera contactar al administrador", "BLOQUEADO");
                            break;
                    }

            }
            else
                MessageBox.Show("Debe ingresar un mail y contraseña!", "ERROR");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();

            textBox2.PasswordChar = '\0'; // Mostramos la contraseña

        }


        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();

            textBox2.PasswordChar = '*'; //Ocultamos la contraseña
        }


        public delegate void DelegadoLogin();
    }
}
