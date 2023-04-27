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
                    MessageBox.Show("Error, mail o contraseña incorrectos");
            }
            else
                MessageBox.Show("Debe ingresar un mail y contraseña!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public delegate void DelegadoLogin();
    }
}
