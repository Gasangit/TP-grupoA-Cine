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
    public partial class Form4 : Form //Form de funciones
    {

        private Cine funcion;

        public TransfDelegado TransfEvento;

        Cine cine = Cine.Instancia;

        public Form4(Cine cine)
        {
            InitializeComponent();
            funcion = cine;
        }

        public delegate void TransfDelegado();

        /*  private void button1_Click(object sender, EventArgs e)
          {
              Sala MiSala = textBox1.Text;
              Pelicula MiPelicula = textBox2.Text;
              Datetime Fecha = textBox3.Text;
              double costo = textBox4.Text;


              if (nombre != null && sinopsis != null && poster != null && duracion != 0)
              {
                  if (cine.altaPelicula(nombre, sinopsis, duracion) != null)
                      MessageBox.Show("Registrado con éxito");
                  else
                      MessageBox.Show("Error, pelicula ya registrada");
              }
              else
                  MessageBox.Show("Debe ingresar un nombre, sinopsis, poster y duracion!");
          }
        */
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
