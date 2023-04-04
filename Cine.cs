﻿using System;
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
            //hay que ver como asignar el id al usuario
            
            Console.WriteLine($">>> Se CREÓ el usuario {usuario.Nombre}" +
                                        $" {usuario.Apellido} con ID {usuario.ID}");
        }
        /* no se que dato se dara para la baja, no creo que el usuario use el ID*/
        public void BajaUsuario(int idUsuario )
        {
            for (int i = 0; i < usuarios.Count; i++) 
            {
                if (usuarios[i].ID == idUsuario)
                {
                    usuarios[i].Bloqueado = true;
                    /*  no se si para dar de baja bloqueo el usuario como se hace en las bases
                     *  de datos o lo borramos */

                    Console.WriteLine($">>> Se ELIMINÓ el usuario {usuarios[i].Nombre}" + 
                                        $" {usuarios[i].Apellido} con ID {usuarios[i].ID}");
                    break;
                }
            }
        }

        public void modificacionUsuario() { 
        }
        public 

        public Sala altaBajaModificacionSala()
        {

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

        public Funcion buscarFuncion(string ubicacion, DateTime fecha, double costo, string pelicula)
        { 
        
        }


    }
}
