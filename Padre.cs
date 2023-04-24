namespace TP_grupoA_Cine
{
    public partial class Padre : Form
    {
        private Cine cine;
        private Form_Login hijoLogin;  //logueo usuario
        private Form_Cartelera hijoCartelera; //Registro de usuarios
        private ABM_Pelicula hijoPelicula; //HAY QUE BORRARLO Y PONER EL REGISTRO

        private TextBox textBox1; //Cuadro Mail
        private TextBox textBox2; //Cuadro Contraseña

        public Padre() //Form principal transparente
        {
            InitializeComponent();
            Cine cine = Cine.Instancia;
            Usuario usuario = cine.altaUsuario(28976543, "Gaston", "Mansilla", "gaston@gmail.com", "123", new DateTime(1982, 04, 02), false);

            //Pantalla pirincipal Form2 Login
            hijoLogin = new Form_Login(cine);
            hijoLogin.MdiParent = this;
            hijoLogin.TransfEvento_LoginCartelera += TransfDelegado_FormCartelera;
            hijoLogin.TransfEvento_LoginRegistro += TransfDelegado_FormRegistro;
            hijoLogin.Show();
        }

        //////////////////////////////////
        //METODOS PARA TRASPASO DE FORMULARIOS
        //////////////////////////////////

        public void TransfDelegado_FormCartelera()
        {
            hijoLogin.Close();

            hijoCartelera = new Form_Cartelera(cine);
            hijoCartelera.MdiParent = this;
            hijoCartelera.Dock = DockStyle.Fill; //Ajuste el hijo a la ventana del padre
            hijoCartelera.Show();

        }

        public void TransfDelegado_FormRegistro() // BORRAR CONTENIDO Y PONER EL REGISTRO
        {
            hijoLogin.Close();

            hijoPelicula = new ABM_Pelicula(cine);
            hijoPelicula.MdiParent = this;
            hijoPelicula.Dock = DockStyle.Fill; //Ajuste el hijo a la ventana del padre
            hijoPelicula.Show();

        }

    }
}