using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
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
            usuario.Bloqueado = true;
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
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].ID == idUsuario)
                {
                    Console.WriteLine($">>> Se MODIFICÓ el USUARIO {usuarios[i].Nombre}" +
                                        $" {usuarios[i].Apellido} con ID {usuarios[i].ID}");
                    return usuarios[i]; //devuelvo un objeto, no se si el form puede usar los atributos.
                }
            }
        }

        public void comprarEntrada(int idUsuario, int idFuncion, int cantidad)
        { 
        
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

        public Funcion buscarFuncion(string ubicacion, DateTime fecha, double costo, string pelicula)
        { 
        
        }

        private Object devolverObjetoDeLista(int ID, string tipoObjeto)
        {
            if (tipoObjeto.ToLower() == "usuario")
            {
                for (int i = 0; i < usuarios.Count; i++)
                {
                    if (usuarios[i].ID == ID)
                    {
                        Usuario usuario = new Usuario();
                        return usuario;
                    }
                }
            }
            else if (tipoObjeto.ToLower() == "sala")
            {
                for (int i = 0; i < salas.Count; i++)
                {
                    if (salas[i].ID == ID)
                    {
                        Sala sala = new Sala();
                        return sala;
                    }
                }
            }
            else if (tipoObjeto.ToLower() == "funcion")
            {
                for (int i = 0; i < funciones.Count; i++)
                {
                    if (funciones[i].ID == ID)
                    {
                        Funcion funcion = new Funcion();
                        return usuario;
                    }
                }
            }
            else
            {
                for (int i = 0; i < peliculas.Count; i++)
                {
                    if (peliculas[i].ID == ID)
                    {
                        Pelicula pelicula = new Pelicula();
                        return pelicula;
                    }
                }
            }
        }

    }
}
