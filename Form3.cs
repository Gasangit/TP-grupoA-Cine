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
    public partial class Form3 : Form    //Form de peliculas
    {
        private Cine pelicula;

        public TransfDelegado TransfEvento;

        Cine cine = Cine.Instancia;
        public Form3(Cine cine)
        {
            pelicula = cine;
            InitializeComponent();
            
        }

        public delegate void TransfDelegado();

        private void button1_Click(object sender, EventArgs e)
        {
        //    string nombre = textBox1.Text;
        //    string sinopsis = textBox2.Text;
        //    string poster = textBox3.Text;
        //    int duracion = textBox4.Text;
        //    bool esAdmin = textBox5.Text;

        //    if (nombre != null && sinopsis != null && poster != null && duracion != 0)
        //    {
        //        if (cine.altaPelicula(nombre, sinopsis, duracion) != null)
        //            MessageBox.Show("Registrado con éxito");
        //        else
        //            MessageBox.Show("Error, pelicula ya registrada");
        //    }
        //    else
        //        MessageBox.Show("Debe ingresar un nombre, sinopsis, poster y duracion!");
        //}

        

        }
    }
}
