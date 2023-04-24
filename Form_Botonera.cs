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
        
        private ABM_Pelicula hijoPelicula; //ABM peliculas
        private AMB_Funciones hijoFuncion;  //ABM funciones
        private ABM_Salas hijoSala; //ABM de Salas
        private ABM_Usuarios hijoUsuario; //ABM de usuarios

        Cine cine = Cine.Instancia;
        public Form_Botonera(Cine cine)        
        {
            
            InitializeComponent();
        }

        public void TransfDelegado3()
        {
            hijoPelicula.Close(); //TENEMOS QUE PONER CUAL FORM SE CIERRA

            hijoPelicula = new ABM_Pelicula(cine);
            hijoPelicula.MdiParent = this;
            hijoPelicula.Dock = DockStyle.Fill;
            hijoPelicula.Show();
        }

        public void TransfDelegado4()
        {
            hijoFuncion.Close(); //TENEMOS QUE PONER CUAL FORM SE CIERRA

            hijoFuncion = new AMB_Funciones(cine);
            hijoFuncion.MdiParent = this;
            hijoFuncion.Dock = DockStyle.Fill;
            hijoFuncion.Show();
        }

        public void TransfDelegado5()
        {
            hijoSala.Close(); //TENEMOS QUE PONER CUAL FORM SE CIERRA

            //hijoSala = new Form5(cine); FALTA EL CONSTRUCTOR EN EL FORM
            hijoSala.MdiParent = this;
            hijoSala.Dock = DockStyle.Fill;
            hijoSala.Show();
        }

        public void TransfDelegado6()
        {
            hijoUsuario.Close(); //TENEMOS QUE PONER CUAL FORM SE CIERRA

            //hijoUsuario = new Form6(cine); FALTA EL CONSTRUCTOR EN EL FORM
            hijoUsuario.MdiParent = this;
            hijoUsuario.Dock = DockStyle.Fill;
            hijoUsuario.Show();
        }        
    }
}
