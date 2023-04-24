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
    public partial class Form_Cartelera : Form //Form del Register
    {
        private Cine register;
        public TransfDelegado TransfEvento;
        Cine cine = Cine.Instancia;
        private int selectedUser;

        public Form_Cartelera(Cine cine)
        {
            register = cine;
            InitializeComponent();
            selectedUser = -1;
        }

        public delegate void TransfDelegado();

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //int dni = textBox1.Text;
        //    string nombre = textBox2.Text;
        //    string apellido = textBox3.Text;
        //    string mail = textBox4.Text;
        //    string password = textBox5.Text;
        //    //DateTime fechaNacimiento = textBox6.Text;
        //    //bool esAdmin = textBox7.Text;

        //    if (nombre != null && nombre != "" && apellido != null && apellido != "" && mail != null && mail != "" && password != null && password != "" && fechaNacimiento != null)
        //    {
        //        if (cine.altaUsuario(dni, nombre, apellido, mail, password, fechaNacimiento,true)
        //            MessageBox.Show("Registrado con éxito");
        //        else
        //            MessageBox.Show("Error, dni, nombre, apellido, mail, password o Fecha de Nacimiento Incorrectos ");
        //    }
        //    else
        //        MessageBox.Show("Debe ingresar  un dni, nombre, apellido, mail, password y Fecha de Nacimiento!");
        //}

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
