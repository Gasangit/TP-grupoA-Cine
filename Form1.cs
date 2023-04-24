namespace TP_grupoA_Cine
{
    public partial class Form1 : Form
    {
        private Cine cine;
        private Form2 hijoLogin;  //logueo usuario
        private Form3 hijoPelicula; //ABM peliculas
        private Form4 hijoFuncion;  //ABM funciones
        private Form5 hijoSala; //ABM de Salas
        private Form6 hijoUsuario; //ABM de usuarios
        private Form7 hijoRegister; //Registro de usuarios

        private TextBox textBox1; //Cuadro Mail
        private TextBox textBox2; //Cuadro Contraseña

        public Form1() //Form principal transparente
        {
            InitializeComponent();
            Cine cine = Cine.Instancia;
            Usuario usuario = cine.altaUsuario(28976543, "Gaston", "Mansilla", "gaston@gmail.com", "123", new DateTime(1982, 04, 02), false);

            //Pantalla pirincipal Form2 Login
            hijoLogin = new Form2(cine);
            hijoLogin.MdiParent = this;
            hijoLogin.TransfEvento += TransfDelegado3;
            hijoLogin.Show();
        }

        //////////////////////////////////
        //METODOS PARA TRASPASO DE FORMULARIOS
        //////////////////////////////////

        public void TransfDelegado3()
        {
            hijoLogin.Close();

            hijoPelicula = new Form3(cine);
            hijoPelicula.MdiParent = this;
            hijoPelicula.Dock = DockStyle.Fill; //Ajuste el hijo a la ventana del padre
            hijoPelicula.Show();
        }

        public void TransfDelegado4()
        {
            hijoFuncion.Close(); //TENEMOS QUE PONER CUAL FORM SE CIERRA

            hijoFuncion = new Form4(cine);
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

        public void TransfDelegado7()
        {
            hijoRegister.Close(); //TENEMOS QUE PONER CUAL FORM SE CIERRA

            hijoRegister = new Form7(cine);
            hijoRegister.MdiParent = this;
            hijoRegister.Dock = DockStyle.Fill;
            hijoRegister.Show();
        }

    }
}