using System;
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

        public int num = 1; 

        int num = 2;

        public Usuario abmUsuario()
        {
            num = 2;
        }

        public void cargarCredito(int idUsuario, double importe)
        { 
        
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

        public Funcion buscarFuncion(string ubicacion, Date fecha, double costo, string pelicula)
        { 
        
        }


    }
}
