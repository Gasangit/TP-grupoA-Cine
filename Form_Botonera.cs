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
        public DelegadoBotonera TransfEvento_BotoneraLogin; //Evento de botonera a login

        public DelegadoBotonera TransEventoUnicoBotonera;

        Cine cine = Cine.Instancia; // Traer el cine
        public Form_Botonera()
        {
            InitializeComponent();

        }


        private void btnCartelera_Click(object sender, EventArgs e)
        {
            this.TransfEvento_BotoneraCartelera();//evento de botonera a cartelera
            //this.TransEventoUnicoBotonera();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            this.TransfEvento_BotoneraPelicula(); //evento de botonera a pelicula
            //this.TransEventoUnicoBotonera();
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            this.TransfEvento_BotoneraSala(); //evento de botonera a sala
            //this.TransEventoUnicoBotonera();
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            this.TransfEvento_BotoneraFuncion(); //evento de botonera a funcion3
            //this.TransEventoUnicoBotonera();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.TransfEvento_BotoneraUsuario(); //evento de botonera a usuario
                                                 //this.TransEventoUnicoBotonera();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.TransfEvento_BotoneraLogin();
        }

        public delegate void DelegadoBotonera();
    }
}
