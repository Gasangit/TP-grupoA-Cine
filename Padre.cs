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
        private TextBox textBox2; //Cuadro Contrase?a

        private Label label1; //Label de prueba cartelera

        public Padre() //Form principal transparente
        {
            InitializeComponent();

            //Dejamos ya registrado 1 objeto de cada tipo/clase
            cine.altaUsuario(28976543, "Gaston", "Mansilla", "gaston@gmail.com", "123", new DateTime(1982, 04, 02), false); // usuario comun 
            cine.altaUsuario(39186055, "Luke", "Skywalker", "luke@gmail.com", "456", new DateTime(1970, 05, 25), true); // usuario admin
            cine.altaSala("Flores", 70);
            cine.altaPelicula("Ant-Man 3", "El doctor Hank Pym anuncia que abandona S.H.I.E.L.D. tras descubrir que han tratado de apropiarse de la tecnologia de su Ant-Man, que Pym considera altamente peligrosa. Varios anios despues, Scott Lang sale de prision tras cumplir tres anios de condena por robo", 135,"A");
            cine.altaFuncion(cine.mostrarSalas()[0], cine.mostrarPeliculas()[0], new DateTime(2023, 04, 28), 1500);

           

            //Pantalla pirincipal Form2 Login
            hijoLogin = new Form_Login();
            hijoLogin.MdiParent = this;
            hijoLogin.Dock = DockStyle.Fill;
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
                establecerBotonesBotoneraAdmin();
                hijoBotonera.Show();
            }
            else
            {
                hijoCartelera = new Form_Cartelera(); //abre Form_Cartelera
                hijoCartelera.MdiParent = this;
                hijoCartelera.Dock = DockStyle.Fill;
                hijoCartelera.TransfEvento_CarteleraBotonera += TransfDelegado_CarteleraBotonera;
                hijoCartelera.Show();
            }

        }

        public void TransfDelegado_FormRegistro() // Cierra Form Login y abre Form Registro
        {
            hijoLogin.Close(); 

            hijoRegistro = new Form_Registro(); 
            hijoRegistro.MdiParent = this;
            hijoRegistro.Dock = DockStyle.Fill;
            hijoRegistro.TransfEvento_Registrarse += TransfDelegado_RegistrarseVolverLogin;
            hijoRegistro.Show();

        }

        public void establecerBotonesBotoneraAdmin()
        {
           
            hijoBotonera.TransfEvento_BotoneraCartelera += TransfDelegado_BotoneraCartelera;
            hijoBotonera.TransfEvento_BotoneraFuncion += TransfDelegado_BotoneraFuncion;
            hijoBotonera.TransfEvento_BotoneraUsuario += TransfDelegado_BotoneraUsuario;
            hijoBotonera.TransfEvento_BotoneraPelicula += TransfDelegado_BotoneraPelicula;
            hijoBotonera.TransfEvento_BotoneraSala += TransfDelegado_BotoneraSala;
            
        }        

        public void establecerBotonesLogin()
        {
            hijoLogin.TransfEvento_LoginCarteleraBotonera += TransfDelegado_FormCarteleraBotonera;
            hijoLogin.TransfEvento_LoginRegistro += TransfDelegado_FormRegistro;
        }

        public void TransfDelegado_BotoneraCartelera() //Cierra Form Botonera y abre Form Cartelera
        {

            hijoBotonera.Close();

            hijoCartelera = new Form_Cartelera();
            hijoCartelera.MdiParent = this;
            hijoCartelera.Dock = DockStyle.Fill;
            hijoCartelera.TransfEvento_CarteleraBotonera += TransfDelegado_CarteleraBotonera;
            hijoCartelera.Show();
        }

        public void TransfDelegado_BotoneraFuncion() //Cierra From Botonera y abre Form Funcion
        {
            hijoBotonera.Close();

            hijoFuncion = new AMB_Funciones();
            hijoFuncion.MdiParent = this;
            hijoFuncion.Dock = DockStyle.Fill;
            hijoFuncion.TransfEvento_FuncionBotonera += TransfDelegado_FuncionBotonera;
            hijoFuncion.Show();
        }

        public void TransfDelegado_BotoneraSala()  //Cierra Form Botonera y abre Form Sala
        {
            hijoBotonera.Close();

            hijoSala = new ABM_Salas();
            hijoSala.MdiParent = this;
            hijoSala.Dock = DockStyle.Fill;
            hijoSala.TransfEvento_SalaBotonera += TransfDelegado_SalaBotonera;
            hijoSala.Show();
        }

        public void TransfDelegado_BotoneraUsuario() //Cierra From Botonera y abre Form Usuarios
        {
            hijoBotonera.Close();

            hijoUsuario = new ABM_Usuarios();
            hijoUsuario.MdiParent = this;
            hijoUsuario.Dock = DockStyle.Fill;
            hijoUsuario.TransfEvento_UsuarioBotonera += TransfDelegado_UsuarioBotonera;
            hijoUsuario.Show();
        }

        public void TransfDelegado_BotoneraPelicula() //Cierra From Botonera y abre Form Peliculas
        {
            hijoBotonera.Close();

            hijoPelicula = new ABM_Pelicula();
            hijoPelicula.MdiParent = this;
            hijoPelicula.Dock = DockStyle.Fill;
            hijoPelicula.TransfEvento_PeliculaBotonera += TransfDelegado_PeliculaBotonera;
            hijoPelicula.Show();
        }        
        
        public void TransfDelegado_RegistrarseVolverLogin() //Cierra el registro y abre el Login
        {
            hijoRegistro.Close();

            hijoLogin = new Form_Login();
            hijoLogin.MdiParent = this;
            hijoLogin.Dock = DockStyle.Fill;
            establecerBotonesLogin();
            hijoLogin.Show();
        }

        public void TransfDelegado_FuncionBotonera() //Cierra Form Funcion y vuelve a la botonera
        {
            hijoFuncion.Close();

            hijoBotonera = new Form_Botonera();
            hijoBotonera.MdiParent = this;
            hijoBotonera.Dock = DockStyle.Fill;
            establecerBotonesBotoneraAdmin();
            hijoBotonera.Show();
        }

        public void TransfDelegado_SalaBotonera() //Cierra Form Sala y vuelve a la botonera
        {
           hijoSala.Close();

           hijoBotonera = new Form_Botonera();
           hijoBotonera.MdiParent = this;
           hijoBotonera.Dock = DockStyle.Fill;
            establecerBotonesBotoneraAdmin();
            hijoBotonera.Show();
        }


        public void TransfDelegado_UsuarioBotonera() //Cierra Form Usuario y vuelve a la botonera
        {
            hijoUsuario.Close();

            hijoBotonera = new Form_Botonera();
            hijoBotonera.MdiParent = this;
            hijoBotonera.Dock = DockStyle.Fill;
            establecerBotonesBotoneraAdmin();
            hijoBotonera.Show();

        }

        
        public void TransfDelegado_PeliculaBotonera()  //Cierra Form Peliculas y vuelve a la botonera
        {
            hijoPelicula.Close();

            hijoBotonera = new Form_Botonera();
            hijoBotonera.MdiParent = this;
            hijoBotonera.Dock = DockStyle.Fill;
            establecerBotonesBotoneraAdmin();
            hijoBotonera.Show();
        }

        public void TransfDelegado_CarteleraBotonera()  //Cierra Form Cartelera y vuelve a la botonera
        {
            hijoCartelera.Close();

            hijoBotonera = new Form_Botonera();
            hijoBotonera.MdiParent = this;
            hijoBotonera.Dock = DockStyle.Fill;
            establecerBotonesBotoneraAdmin();
            hijoBotonera.Show();
        }
    }
}