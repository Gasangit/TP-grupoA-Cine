using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TP_grupoA_Cine
{
    internal class Cine
    {

        public List<Usuario> usuarios { get; set; }
        public List<Funcion> funciones { get; set; }
        public List<Sala> salas { get; set; }
        public List<Pelicula> peliculas { get; set; }
        public Usuario usuarioActual { get; set; }

        private readonly static Cine _instancia = new Cine(); //patron singleton para que siempre haya un solo objeto Cine

        private Cine() { }; //patron singleton para que siempre haya un solo objeto Cine

        public static Cine Instancia  //patron singleton para que siempre haya un solo objeto Cine
        {
            get
            { 
                return _instancia;
            }
        }
        
        public Usuario altaUsuario(int dni, string nombre,
                                    string apellido, string mail, string password, 
                                    DateTime fechaNacimiento, bool esAdmin)
        {
            //la clase Usuario tiene que tener un constructor para el ALTA
            Usuario usuario = new Usuario(dni, nombre, apellido, mail, password, fechaNacimiento, esAdmin);
            //el ID se puede generar automaticamente con un atributo estatico en la clase Usuario
            
            Console.WriteLine($">>> Se CREÓ el USUARIO {usuario.Nombre}" +
                                        $" {usuario.Apellido} con ID {usuario.ID}");
            return usuario;
        }
        

        public void bajaUsuario(int idUsuario)
        {
            Usuario usuario = devolverObjetoDeLista(idUsuario, "usuario");
            usuario.Bloqueado = true;   //no se si se lo bloquea, se lo pasa a null.
                                        //Seguro si se lo saca de la lista
            Console.WriteLine($">>> Se ELIMINÓ el USUARIO {usuario.Nombre}" + 
                                $" {usuario.Apellido} con ID {usuario.ID}");            
        }

        public void modificacionUsuario(int idUsuario) {

            //acá se pueden llamar los datos del usuario en la base de datos y verificar cual es diferente
            //para cambiarlo. Mientras tanto se modifica el objeto.

            Usuario usuario = devolverObjetoDeLista(idUsuario, "usuario");
            Console.WriteLine($">>> Se MODIFICÓ el USUARIO {usuario.Nombre}" +
                                $" {usuario.Apellido} con ID {usuario.ID}");
            return usuario; ; //devuelvo un objeto, no se si el form puede usar los atributos.
             

        }
        public 

        public Sala altaSala(string ubicacion, int capacidad)
        {   
            //tiene que haber un contructor en sala especial para crearla. El ID se puede generar
            //automaticamente con un atributo estatico en la clase Sala.
            Sala sala = new Sala(ubicacion, capacidad);

            Console.WriteLine($">>> Se CREÓ la SALA ubicada en {sala.Ubicacion}" + 
                                $" con capacidad para {sala.Capacidad} espectadores");
            return sala;
        }

        public void bajaSala(int idSala)
        {
            

            Console.WriteLine($">>> Se ELIMINÓ la SALA ubicada en {salas[i].Ubicacion}" +
                                $" con capacidad para {salas[i].Capacidad} espectadores");
                   
        }

        public void cargarCredito(int idUsuario, double importe)
        {
            Usuario usuario = devolverObjetoDeLista(idUsuario, "usuario");
            usuario.Credito = usuario.Credito + importe;
            Console.WriteLine($"Se CARGARON $ {importe} quedando el CRÉDITO en {usuario.Credito}\nID usuario : {usuario.ID}");
        }

        public void comprarEntrada(int idUsuario, int idFuncion, int cantidad)
        {
            Usuario usuario = devolverObjetoDeLista(idUsuario, "usuario");
            Usuario funcion = devolverObjetoDeLista(idFuncion, "funcion");

            if (funcion.Costo > usuario.Credito)
            {
                Console.WriteLine($">>> CRÉDITO insuficiente para comprar la/s {cantidad} entrada/s");
            }
        }

        public void devolverEntrada(int idUsuario, int cantidad)
        { 
        
        }

        public void iniciarSesion(string mail, string password) 
        {
            
        }

        public void cerrarSesion()
        { 
        
        }

        /*  recordar que las listas se tienen que devolver (return) con el método ToList() para no
            devolver la lista original y que la misma no sea modificada.    */
        public Funcion mostrarFunciones() 
        {
            return funciones.ToList();
        }

        /*  recordar que las listas se tienen que devolver (return) con el método ToList() para no
            devolver la lista original y que la misma no sea modificada.    */
        public Sala mostrarSalas()
        {
            return salas.ToList();
        }

        /*  recordar que las listas se tienen que devolver (return) con el método ToList() para no
            devolver la lista original y que la misma no sea modificada.    */
        public Pelicula mostrarPeliculas()
        {
            return peliculas.ToList();
        }

        public Funcion buscarFuncion(DateTime fecha, string ubicacion = "no", double costo = -3, string pelicula = "no")
        { 
        
        }

        private object devolverObjetoDeLista(int ID, string tipoObjeto)
        {
            Object objeto = new Object();

            if (tipoObjeto.ToLower() == "usuario")
            {
                for (int i = 0; i < usuarios.Count(); i++)
                {
                    if (usuarios[i].ID == ID)
                    {
                        objeto = new Usuario();
                    }
                }
            }
            else if (tipoObjeto.ToLower() == "sala")
            {
                for (int i = 0; i < salas.Count(); i++)
                {
                    if (salas[i].ID == ID)
                    {
                        objeto = new Sala();
                    }
                }
            }
            else if (tipoObjeto.ToLower() == "funcion")
            {
                for (int i = 0; i < funciones.Count(); i++)
                {
                    if (funciones[i].ID == ID)
                    {
                        objeto = new Funcion();
                    }
                }
            }
            else if (tipoObjeto.ToLower() == "pelicula")
            {
                for (int i = 0; i < peliculas.Count(); i++)
                {
                    if (peliculas[i].ID == ID)
                    {
                        objeto = new Pelicula();
                    }
                }
            }
            else { Console.WriteLine(">>> Se devuelve un OBJETO GENERICO, no se identificó el objeto que desea generar"); }
            return objeto;
        }

        private bool darDeBajaObjeto(int ID, string lista)
        {
            string mensaje = (" <<< No se generó el mensaje >>> ");
            bool resultado = false;

            if (lista.ToLower() == "usuarios")
            {
                for (int i = 0; i < this.usuarios.Count(); i++)
                {
                    if (this.usuarios[i].ID == ID)
                    {
                        mensaje = $" el USUARIO {this.usuarios[i].Nombre}" + $"{this.usuarios[i].Apellido} con ID {this.usuarios[i].ID}";
                        resultado = true;
                        usuarios.Remove(this.usuarios[i]);
                    }
                }
            }
            else if (lista.ToLower() == "funciones")
            {
                for (int i = 0; i < this.funciones.Count(); i++)
                {
                    if (this.funciones[i].ID == ID)
                    {
                        mensaje = $" la FUNCION con ID {this.funciones[i].ID}";
                        resultado = true;
                        funciones.Remove(this.funciones[i]);
                    }
                }
            }
            else if (lista.ToLower() == "salas")
            {
                for (int i = 0; i < this.salas.Count(); i++)
                {
                    if (salas[i].ID == ID)
                    {
                        mensaje = $" la SALA con ID {this.salas[i].ID}";
                        resultado = true;
                        salas.Remove(this.salas[i]);
                    }
                }
            }
            else if (lista.ToLower() == "peliculas")
            {
                for (int i = 0; i < this.peliculas.Count(); i++)
                {
                    if (this.peliculas[i].ID == ID)
                    {
                        mensaje = $" la PELICULA con ID {this.peliculas[i].ID}";
                        resultado = true;
                        salas.Remove(this.peliculas[i]);
                    }
                }
            }
            else { Console.WriteLine(">> No se pudo realizar la BAJA. Verificar ID y NOMBRE DE LISTA"); }

            Console.WriteLine($"Se dió de BAJA {mensaje}");
            return resultado;
        }
    }
}