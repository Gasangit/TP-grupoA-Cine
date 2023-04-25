using static TP_grupoA_Cine.Form_Botonera;

namespace TP_grupoA_Cine
{
    public partial class Padre : Form
    {
        Cine cine = Cine.Instancia; // Trae el cine

        private Form_Login hijoLogin;  //logueo usuario
        private Form_Cartelera hijoCartelera; //Cartelera
        private Form_Registro hijoRegistro; //Registro de usuario
        private ABM_Pelicula hijoPelicula; //ABM peliculas
        private AMB_Funciones hijoFuncion;  //ABM funciones
        private ABM_Salas hijoSala; //ABM de Salas
        private ABM_Usuarios hijoUsuario; //ABM de usuarios
        private Form_Botonera hijoBotonera; // Botonera vista del Administrador                       

        private TextBox textBox1; //Cuadro Mail
        private TextBox textBox2; //Cuadro Contraseña

        private Label label1; //Label de prueba cartelera

        public Padre() //Form principal transparente
        {
            InitializeComponent();
            
            //Dejamos ya registrado 1 objeto de cada tipo/clase
            Usuario usuario1 = cine.altaUsuario(28976543, "Gaston", "Mansilla", "gaston@gmail.com", "123", new DateTime(1982, 04, 02), false); // usuario comun 
            Usuario usuario2 = cine.altaUsuario(39186055, "Luke", "Skywalker", "luke@gmail.com", "456", new DateTime(1970, 05, 25), true); // usuario admin
            Sala sala1 = cine.altaSala("Flores", 70);
            Pelicula antman = cine.altaPelicula("Ant-Man 3", "El doctor Hank Pym anuncia que abandona S.H.I.E.L.D. tras descubrir que han tratado de apropiarse de la tecnología de su Ant-Man, que Pym considera altamente peligrosa. Varios años después, Scott Lang sale de prisión tras cumplir tres años de condena por robo.", 135);
            Funcion antmanf1 = cine.altaFuncion(sala1, antman, new DateTime(2023, 04, 28), 1500);

            //Pantalla pirincipal Form2 Login
            hijoLogin = new Form_Login();
            hijoLogin.MdiParent = this;
            hijoLogin.TransfEvento_LoginCarteleraBotonera += TransfDelegado_FormCarteleraBotonera; //evento de login a cartelera, si es usuario comun, o botonera, si es usuario admin
            hijoLogin.TransfEvento_LoginRegistro += TransfDelegado_FormRegistro; // evento de login a registro
                                                                                 
            hijoLogin.Show();

        }

        ////////////////////////////////////////
        //METODOS PARA TRASPASO DE FORMULARIOS//
        ////////////////////////////////////////

        
        public void TransfDelegado_FormCarteleraBotonera() //Cierra el login y abre Form Cartelera, si es usuario comun, o botonera, si es usuario admin
        {              
                   hijoLogin.Close(); //cierra login

            if (cine.usuarioActual.EsAdmin)
            {
                hijoBotonera = new Form_Botonera(); //abre Form_Botonera
                hijoBotonera.MdiParent = this;
                hijoBotonera.Dock = DockStyle.Fill;
                hijoBotonera.TransfEvento_BotoneraCartelera += TransfDelegado_BotoneraCartelera;
                hijoBotonera.TransfEvento_BotoneraFuncion += TransfDelegado_BotoneraFuncion;
                hijoBotonera.Show();
            } else
            {
                hijoCartelera = new Form_Cartelera(); //abre Form_Cartelera
                hijoCartelera.MdiParent = this;
                hijoCartelera.Dock = DockStyle.Fill;
                hijoCartelera.Show();
            }
                   
        }
        
        public void TransfDelegado_FormRegistro() // Cierra Form Login y abre Form Registro
        {
            hijoLogin.Close(); //cierra login

            hijoRegistro = new Form_Registro(); //abre ABM_Registro
            hijoRegistro.MdiParent = this;
            hijoRegistro.Dock = DockStyle.Fill;
            hijoRegistro.Show();

        }        

        public void TransfDelegado_BotoneraCartelera() //Cierra Form Botonera y abre Form Cartelera
        {
           
            hijoBotonera.Close(); //cierra botonera

            hijoCartelera = new Form_Cartelera();
            hijoCartelera.MdiParent = this;
            hijoCartelera.Dock = DockStyle.Fill;
            hijoCartelera.Show(); 
        }

        public void TransfDelegado_BotoneraFuncion() //Cierra From Botonera y abre Form Funcion
        {
            hijoBotonera.Close();

            hijoFuncion = new AMB_Funciones();
            hijoFuncion.MdiParent = this;
            hijoFuncion.Dock = DockStyle.Fill;
            hijoFuncion.Show();        
        }

    }
}