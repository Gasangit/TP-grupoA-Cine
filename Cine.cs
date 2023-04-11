using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        public Cine() 
        { 
        } //patron singleton para que siempre haya un solo objeto Cine

        public static Cine Instancia  //patron singleton para que siempre haya un solo objeto Cine
        {
            get
            { 
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
            
            Console.WriteLine($">>> Se CREÓ el USUARIO {usuario.Nombre}" +
                                        $" {usuario.Apellido} con ID {usuario.ID}");
            return usuario;
        }
        public void bajaUsuario(int idUsuario)
        {
            Usuario usuario = obtenerObjetoDeLista(idUsuario, "usuario");
            usuarios.Remove(usuario);
            usuario.Bloqueado = true;   //no se si se lo bloquea, se lo pasa a null.
                                        //Seguro si se lo saca de la lista
            Console.WriteLine($">>> Se ELIMINÓ el USUARIO {usuario.Nombre}" + 
                                $" {usuario.Apellido} con ID {usuario.ID}");
            usuario = null;
        }
        public void modificacionUsuario(int idUsuario) {

            //acá se pueden llamar los datos del usuario en la base de datos y verificar cual es diferente
            //para cambiarlo. Mientras tanto se modifica el objeto.

            Usuario usuario = obtenerObjetoDeLista(idUsuario, "usuario");
                

            Console.WriteLine($">>> Se MODIFICÓ el USUARIO {usuario.Nombre}" +
                                $" {usuario.Apellido} con ID {usuario.ID}");
        }
        // SALA --------------------------------------------------------------------------------------------
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
            Sala sala = obtenerObjetoDeLista(idSala, "sala");
            salas.Remove(sala);
            Console.WriteLine($">>> Se ELIMINÓ la SALA ubicada en {sala.Ubicacion}" +
                                $" con capacidad para {sala.Capacidad} espectadores");
            sala = null;
        }
        public void modificacionSala(int idSala)
        {
            //acá se pueden llamar los datos del usuario en la base de datos y verificar cual es diferente
            //para cambiarlo. Mientras tanto se modifica el objeto.

            Sala sala = obtenerObjetoDeLista(idSala, "usuario");
            //habria que tomar los campos del FORM y aplicarlos al objeto sala
            Console.WriteLine($">>> Se MODIFICÓ la SALA con ID {sala.ID}");
        }

        public void cargarCredito(int idUsuario, double importe)
        {
            Usuario usuario = obtenerObjetoDeLista(idUsuario, "usuario");
            usuario.Credito +=  importe;
            Console.WriteLine($"Se CARGARON $ {importe} quedando el CRÉDITO en {usuario.Credito}\nID usuario : {usuario.ID}");
        }

        public void comprarEntrada(int idUsuario, int idFuncion, int cantidad)
        {
            Usuario usuario = obtenerObjetoDeLista(idUsuario, "usuario");
            Usuario funcion = obtenerObjetoDeLista(idFuncion, "funcion");

            double importe = funcion.Costo * cantidad;
            int entradasDispoibles = funcion.MiSala.Capacidad - funcion.CantClientes;

            if (importe > usuario.Credito)
            {
                Console.WriteLine($">>> CRÉDITO insuficiente para comprar la/s {cantidad} entrada/s");
            }
            else if (entradasDispoibles < cantidad)
            {
                Console.WriteLine($"No pueden venderse {cantidad} entradas quedan disponibles {entradasDispoibles}");
            }
            else
            {
                usuario.Credito -= importe;
                funcion.CantClientes += cantidad;
                Console.WriteLine($">>> VENTA : \n  Cantidad Entradas: {cantidad}" + 
                                    $"\n Importe : {importe}\nPrecio entrada : {funcion.Costo}");
            }
        }

        public void devolverEntrada(int idUsuario, int cantidad)
        {
            //la cantidad de entrada que compra el cliente para un funcion no queda
            //guardada en ningun lugar. Puede comprar 2 y pedir que le devuelvan 4.
            Usuario usuario = obtenerObjetoDeLista(idUsuario, "usuario");
            Usuario funcion = usuario.MisFunciones[idFuncion]; //en el UML no esta pero el método
                                                               //tendría que tener un ID de Funcion

            double importe = funcion.Costo * cantidad;// el IMPORTE a devolver por las entradas es el
                                                      // COSTO de la FUNCION por la CANTIDAD de entradas
            usuario.Credito += importe;         //se reintegra SALDO al CLIENTE
            funcion.CantClientes -= cantidad;   //se descuentan las ENTRADAS devueltas
                                                //de la CANTIDAD DE CLIENTE en al FUNCION
            Console.WriteLine($">>> VENTA : \n  Cantidad Entradas: {cantidad}" +
                                $"\n Importe : {importe}\nPrecio entrada : {funcion.Costo}");
        }
        //se ingresa como ARGUMENTOS mail y password desde FORM
        public void iniciarSesion(string mail, string password) 
        {
            for (int i = 0; i < this.usuarios.Count(); i++)
            {   //se comprueba MAIL
                if (usuarios[i].Mail = mail)
                {   //se comprueba PASSWORD
                    if (usuarios[i].Password = password) 
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

        /*  recordar que las listas se tienen que devolver (return) con el método ToList() para no
            devolver la lista original y que la misma no sea modificada.    */
        public Funcion mostrarFunciones() 
        {
            return funciones.ToList();
        }
        public Sala mostrarSalas()
        {
            return salas.ToList();
        }
        public Pelicula mostrarPeliculas()
        {
            return peliculas.ToList();
        }

        /*public Funcion buscarFuncion(DateTime fecha = , string ubicacion, double costo = -3, string pelicula = "no")
        {
            bool argUbicacionOK;
            bool argUbicacion;
            bool argCosto;
            bool argPelicula;


            if (ubicacion != null) { }

            foreach (Funcion funcion in funciones) {

                if (fecha != "no" && funcion.Fecha == fecha)
                {
                    bool fechaOk = true;

                    if (ubicacion != "no" && funcion.Fecha == fecha)
                    {
                        bool fechaOk = true;
                    }
                    if (fecha != "no" && funcion.Fecha == fecha)
                    {
                        bool fechaOk = true;
                    }
                    if (fecha != "no" && funcion.Fecha == fecha)
                    {
                        bool fechaOk = true;
                    }
            }        

        }*/

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
            Object objeto = new Object();

            if (tipoObjeto.ToLower() == "usuario")
            {
                for (int i = 0; i < usuarios.Count(); i++)
                {
                    if (usuarios[i].ID == ID)
                    {
                        objeto = usuarios[i];
                    }
                }
            }
            else if (tipoObjeto.ToLower() == "sala")
            {
                for (int i = 0; i < salas.Count(); i++)
                {
                    if (salas[i].ID == ID)
                    {
                        objeto = salas[i];
                    }
                }
            }
            else if (tipoObjeto.ToLower() == "funcion")
            {
                for (int i = 0; i < funciones.Count(); i++)
                {
                    if (funciones[i].ID == ID)
                    {
                        objeto = funciones[i];
                    }
                }
            }
            else if (tipoObjeto.ToLower() == "pelicula")
            {
                for (int i = 0; i < peliculas.Count(); i++)
                {
                    if (peliculas[i].ID == ID)
                    {
                        objeto = peliculas[i];
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