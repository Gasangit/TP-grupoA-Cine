using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TP_grupoA_Cine
{
    internal class Cine
    {

        public List<Usuario> usuarios { get; set; } = new List<Usuario>();
        public List<Funcion> funciones { get; set; } = new List<Funcion>();
        public List<Sala> salas { get; set; } = new List<Sala>();
        public List<Pelicula> peliculas { get; set; } = new List<Pelicula>();
        public Usuario usuarioActual { get; set; }

        // SINGLETON -------------------------------------------------------------------------------------------
        private readonly static Cine _instancia = new Cine();

        private Cine() {}

        public static Cine Instancia
        {
            get
            {
                Debug.WriteLine(">>> (Cine - Instancia) Se genera Instancia Cine Singleton");
                return _instancia;
            }
        }
        // USUARIO --------------------------------------------------------------------------------------------
        public Usuario altaUsuario(int dni, string nombre,
                                    string apellido, string mail, string password, 
                                    DateTime fechaNacimiento, bool esAdmin)
        {
            //la clase Usuario tiene que tener un constructor para el ALTA
            Usuario usuario = new Usuario(dni, nombre, apellido, mail, password, fechaNacimiento, esAdmin);
            //el ID se puede generar automaticamente con un atributo estatico en la clase Usuario
            usuarios.Add(usuario);
            Debug.WriteLine($">>> (Cine - altaUsuario()) Se CREÓ el USUARIO {usuario.Nombre}" +
                                        $" {usuario.Apellido} con ID {usuario.ID}");
            return usuario;
        }
        public void bajaUsuario(int idUsuario)
        {
            Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");
            usuarios.Remove(usuario);
            usuario.Bloqueado = true;   //no se si se lo bloquea, se lo pasa a null.
                                        //Seguro si se lo saca de la lista
            Debug.WriteLine($">>> (Cine - bajaUsuario()) Se ELIMINÓ el USUARIO {usuario.Nombre}" + 
                                $" {usuario.Apellido} con ID {usuario.ID}");
            usuario = null;
        }
        public void modificacionUsuario(int idUsuario) {

            //acá se pueden llamar los datos del usuario en la base de datos y verificar cual es diferente
            //para cambiarlo. Mientras tanto se modifica el objeto.

            Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");
                

            Debug.WriteLine($">>> Se MODIFICÓ el USUARIO {usuario.Nombre}" +
                                $" {usuario.Apellido} con ID {usuario.ID}");
        }
        // SALA --------------------------------------------------------------------------------------------
        public Sala altaSala(string ubicacion, int capacidad)
        {   
            //tiene que haber un contructor en sala especial para crearla. El ID se puede generar
            //automaticamente con un atributo estatico en la clase Sala.
            Sala sala = new Sala(ubicacion, capacidad);
            salas.Add(sala);

            Debug.WriteLine($">>> (Cine - altaSala()) Se CREÓ la SALA ubicada en {sala.Ubicacion}" + 
                                $" con capacidad para {sala.Capacidad} espectadores");
            return sala;
        }

        public void bajaSala(int idSala)
        {
            Sala sala = (Sala)obtenerObjetoDeLista(idSala, "sala");
            salas.Remove(sala);
            Debug.WriteLine($">>> Se ELIMINÓ la SALA ubicada en {sala.Ubicacion}" +
                                $" con capacidad para {sala.Capacidad} espectadores");
            sala = null;
        }
        public void modificacionSala(int idSala)
        {
            //acá se pueden llamar los datos del usuario en la base de datos y verificar cual es diferente
            //para cambiarlo. Mientras tanto se modifica el objeto.

            Sala sala = (Sala)obtenerObjetoDeLista(idSala, "usuario");
            //habria que tomar los campos del FORM y aplicarlos al objeto sala
            Debug.WriteLine($">>> Se MODIFICÓ la SALA con ID {sala.ID}");
        }

        // FUNCION --------------------------------------------------------------------------------------------
        public Funcion altaFuncion(Sala sala, Pelicula pelicula, DateTime fecha, double costo)
        {
            
            Funcion funcion = new Funcion(sala, pelicula, fecha, 0,costo); //se pasa cero pero no habría que ingresar Cantidad de clientes
            funciones.Add(funcion);

            Debug.WriteLine($">>> (Cine - altaFuncion()) Se CREÓ la FUNCION en la sala {funcion.MiSala}" +
                                $" para la película {funcion.MiPelicula} en la fecha {funcion.Fecha} con un costo de {funcion.Costo}");
            return funcion;
        }
        public void bajaFuncion(int idFuncion)
        {
            Funcion funcion= (Funcion)obtenerObjetoDeLista(idFuncion, "funcion");
            funciones.Remove(funcion);
            Debug.WriteLine($">>> (Cine - bajafuncion()) Se dió de baja la FUNCIÓN con ID {funcion.ID}");
            funcion = null;
        }
        // PELICULA -------------------------------------------------------------------------------------------
        public Pelicula altaPelicula(string nombre, string sinopsis, int duracion)
        {

            Pelicula pelicula = new Pelicula(nombre, sinopsis, duracion);
            peliculas.Add(pelicula);

            Debug.WriteLine($">>> (Cine - altaPelicula()) Se creó la PELÍCULA {pelicula.Nombre} con ID {pelicula.ID}");
            return pelicula;
        }
        public void bajaPelicula(int idPelicula)
        {
            Pelicula pelicula = (Pelicula)obtenerObjetoDeLista(idPelicula, "pelicula");
            peliculas.Remove(pelicula);
            Debug.WriteLine($">>> (Cine - bajaPelicula()) Se dió de baja la PELÍCULA {pelicula.Nombre} con ID {pelicula.ID}");
            pelicula = null;
        }

        // TRANSACCIONES --------------------------------------------------------------------------------------

        public void cargarCredito(int idUsuario, double importe)
        {
            Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");
            usuario.Credito +=  importe;
            Debug.WriteLine($">>> (Cine - cargarCredito()) Se CARGARON $ {importe} quedando el CRÉDITO en {usuario.Credito} ID usuario : {usuario.ID}");
        }

        public void comprarEntrada(int idUsuario, int idFuncion, int cantidad)
        {
            Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");
            Funcion funcion = (Funcion)obtenerObjetoDeLista(idFuncion, "funcion");

            double importe = funcion.Costo * cantidad;
            int entradasDispoibles = funcion.MiSala.Capacidad - funcion.CantClientes;

            if (importe > usuario.Credito)
            {
                Debug.WriteLine($">>> (Cine - comprarEntrada()) CRÉDITO insuficiente para comprar la/s {cantidad} entrada/s");
            }
            else if (entradasDispoibles < cantidad)
            {
                Debug.WriteLine($">>> (Cine - comprarEntrada()) No pueden venderse {cantidad} entradas quedan disponibles {entradasDispoibles}");
            }
            else
            {
                usuario.Credito -= importe;
                funcion.CantClientes += cantidad;
                Debug.WriteLine($">>> >>> (Cine - comprarEntrada()) VENTA : \n  Cantidad Entradas: {cantidad}" + 
                                    $"\n Importe : {importe}\nPrecio entrada : {funcion.Costo}");
            }
        }

        public void devolverEntrada(int idUsuario,int idFuncion, int cantidad) //se agreaga idFuncion (no esta en UML)
        {
            //la cantidad de entrada que compra el cliente para un funcion no queda
            //guardada en ningun lugar. Puede comprar 2 y pedir que le devuelvan 4.
            Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");
            Funcion funcion = usuario.MisFunciones[idFuncion]; //en el UML no esta pero el método
                                                               //tendría que tener un ID de Funcion

            double importe = funcion.Costo * cantidad;// el IMPORTE a devolver por las entradas es el
                                                      // COSTO de la FUNCION por la CANTIDAD de entradas
            usuario.Credito += importe;         //se reintegra SALDO al CLIENTE
            funcion.CantClientes -= cantidad;   //se descuentan las ENTRADAS devueltas
                                                //de la CANTIDAD DE CLIENTE en al FUNCION
            Debug.WriteLine($">>> VENTA : \n  Cantidad Entradas: {cantidad}" +
                                $"\n Importe : {importe}\nPrecio entrada : {funcion.Costo}");
        }

        // SESION --------------------------------------------------------------------------------------------

        //se ingresa como ARGUMENTOS mail y password desde FORM
        public void iniciarSesion(string mail, string password) 
        {
            for (int i = 0; i < this.usuarios.Count(); i++)
            {   //se comprueba MAIL
                if (usuarios[i].Mail == mail)
                {   //se comprueba PASSWORD
                    if (usuarios[i].Password == password) 
                    {
                        this.usuarioActual = usuarios[i];
                    }                
                }
            }
        }

        public void cerrarSesion()
        {
            this.usuarioActual = null;
        }

        // FRONT --------------------------------------------------------------------------------------------

        /*  recordar que las listas se tienen que devolver (return) con el método ToList() para no
            devolver la lista original y que la misma no sea modificada.    */
        public List<Funcion> mostrarFunciones() 
        {
            return funciones.ToList();
        }
        public List<Sala> mostrarSalas()
        {
            return salas.ToList();
        }
        public List<Pelicula> mostrarPeliculas()
        {
            return peliculas.ToList();
        }

        
        //public Funcion buscarFuncion(DateTime fecha = new DateTime(), string ubicacion, 
        //                                    double costo = -3, string pelicula = "no")
        //{
        //    bool argfecha;
        //    bool argUbicacion;
        //    bool argCosto;
        //    bool argPelicula;


        //    if (ubicacion != null) { }

        //    foreach (Funcion funcion in funciones) {

        //        if (fecha != "no" && funcion.Fecha == fecha)
        //        {
        //            bool fechaOk = true;

        //            if (ubicacion != "no" && funcion.Fecha == fecha)
        //            {
        //                bool fechaOk = true;
        //            }
        //            if (fecha != "no" && funcion.Fecha == fecha)
        //            {
        //                bool fechaOk = true;
        //            }
        //            if (fecha != "no" && funcion.Fecha == fecha)
        //            {
        //                bool fechaOk = true;
        //            }
        //    }        

        //}

        //private object objetodelista(int id, string lista)//metodo para acortar el código al buscar un objeto
        //{
        //    object devolverobjeto = new object();
        //    list<list<object>> listas = new list<list<object>>() { this.usuarios.cast<object>().tolist(), this.salas.cast<object>().tolist(),
        //                                                        this.funciones.cast<object>().tolist(), this.peliculas.cast<object>().tolist() };
        //    for (int i = 0; i < listas.count(); i++)
        //    {
        //        if (listas[i].gettype().name == lista)
        //        {
        //            for (int k = 0; k < listas[i].count(); k++)
        //            {
        //                if (listas[i][k].id == id) //esto tiene que dar un objeto
        //                {
        //                    devolverobjeto = listas[i][k];
        //                    return devolverobjeto;
        //                }
        //            }
        //        }
        //    }
        //}

        private object obtenerObjetoDeLista(int ID, string tipoObjeto)
        {
            object objeto = new { ID = "Objeto no encontrado"};

            if (tipoObjeto.ToLower() == "usuario")
            {
                for (int i = 0; i < usuarios.Count; i++)
                {
                    if (usuarios[i].ID == ID)
                    {
                        objeto = usuarios[i];
                    }
                }
            }
            else if (tipoObjeto.ToLower() == "sala")
            {
                for (int i = 0; i < salas.Count; i++)
                {
                    if (salas[i].ID == ID)
                    {
                        objeto = salas[i];
                    }
                }
            }
            else if (tipoObjeto.ToLower() == "funcion")
            {
                for (int i = 0; i < funciones.Count; i++)
                {
                    if (funciones[i].ID == ID)
                    {
                        objeto = funciones[i];
                    }
                }
            }
            else if (tipoObjeto.ToLower() == "pelicula")
            {
                for (int i = 0; i < peliculas.Count; i++)
                {
                    if (peliculas[i].ID == ID)
                    {
                        objeto = peliculas[i];
                    }
                }
            }
            else 
            { 
                Console.WriteLine(">>> Se devuelve un OBJETO GENERICO, no se identificó el objeto que desea generar");
            }
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
                        peliculas.Remove(this.peliculas[i]);
                    }
                }
            }
            else { Console.WriteLine(">> No se pudo realizar la BAJA. Verificar ID y NOMBRE DE LISTA"); }

            Console.WriteLine($"Se dió de BAJA {mensaje}");
            return resultado;
        }
    }
}