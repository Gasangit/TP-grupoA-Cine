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
    public partial class Form_Botonera : Form
    {
        public DelegadoBotonera TransfEvento_BotoneraCartelera; //evento de botonera a cartelera
        public DelegadoBotonera TransfEvento_BotoneraPelicula; //evento de botonera a pelicula
        public DelegadoBotonera TransfEvento_BotoneraSala; //evento de botonera a sala
        public DelegadoBotonera TransfEvento_BotoneraFuncion; //evento de botonera a funcion
        public DelegadoBotonera TransfEvento_BotoneraUsuario; //evento de botonera a usuario

        Cine cine = Cine.Instancia; // Traer el cine
        public Form_Botonera()
        {
            InitializeComponent();
        }

        private void btnCartelera_Click(object sender, EventArgs e)
        {
            this.TransfEvento_BotoneraCartelera(); //evento de botonera a cartelera
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            this.TransfEvento_BotoneraPelicula(); //evento de botonera a pelicula
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            this.TransfEvento_BotoneraSala(); //evento de botonera a sala
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            this.TransfEvento_BotoneraFuncion(); //evento de botonera a funcion
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.TransfEvento_BotoneraUsuario(); //evento de botonera a usuario
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public delegate void DelegadoBotonera();
    }
}
