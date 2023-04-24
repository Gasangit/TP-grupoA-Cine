﻿using System;
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
    public partial class Form2 : Form //Form del Login
    {
        private Cine login;
        public TransfDelegado TransfEvento;

        Cine cine = Cine.Instancia;
        public Form2(Cine cine)
        {
            login = cine;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) //Registrarse
        {
            
        }

        private void button2_Click(object sender, EventArgs e) //Login
        {
            string mail = textBox1.Text;
            string password = textBox2.Text;
            if (mail != null && mail != "" && password != null && password != "")
            {
                if (cine.iniciarSesion(mail, password))
                    this.TransfEvento();
                else
                    MessageBox.Show("Error, mail o contraseña incorrectos");
            }
            else
                MessageBox.Show("Debe ingresar un mail y contraseña!");
        }
        public delegate void TransfDelegado();
    }
}
