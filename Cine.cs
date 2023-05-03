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
    public class Cine
    {

        public List<Usuario> usuarios { get; set; } = new List<Usuario>();
        public List<Funcion> funciones { get; set; } = new List<Funcion>();
        public List<Sala> salas { get; set; } = new List<Sala>();
        public List<Pelicula> peliculas { get; set; } = new List<Pelicula>();
        public Usuario usuarioActual { get; set; } 


        public string nombreUsuario() {

            return usuarioActual.Nombre;
        }
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
        public bool altaUsuario(int dni, string nombre,
                                   string apellido, string mail, string password,
                                   DateTime fechaNacimiento, bool esAdmin)
        {
            //la clase Usuario tiene que tener un constructor para el ALTA
            Usuario usuario = new Usuario(dni, nombre, apellido, mail, password, fechaNacimiento, esAdmin);
            //el ID se puede generar automaticamente con un atributo estatico en la clase Usuario
            usuarios.Add(usuario);
            Debug.WriteLine($">>> (Cine - altaUsuario()) Se CREÓ el USUARIO {usuario.Nombre}" +
                                        $" {usuario.Apellido} con ID {usuario.ID}");
            return true;
        }        

        public void bajaUsuario(int idUsuario)
        {
            try
            {
                Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");


                usuarios.Remove(usuario);
                usuario.Bloqueado = true;
                Debug.WriteLine($">>> (Cine - bajaUsuario()) Se ELIMINÓ el USUARIO {usuario.Nombre}" +
                                    $" {usuario.Apellido} con ID {usuario.ID}");
                usuario = null;
            }
            catch (Exception ex) { Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado."); }

        }
        public bool modificacionUsuario(int idUsuario, int dni, string nombre, string apellido, string mail, string password, DateTime fechaNacimiento, bool esAdmin, bool bloqueado) {

            try
            {
                Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");

                usuario.ID = idUsuario;
                usuario.DNI = dni;
                usuario.Nombre = nombre;
                usuario.Apellido = apellido;
                usuario.Mail = mail;
                usuario.Password = password;
                usuario.FechaNacimiento = fechaNacimiento;
                usuario.EsAdmin = esAdmin;
                usuario.Bloqueado = bloqueado;

                Debug.WriteLine($">>> Se MODIFICÓ el USUARIO {usuario.Nombre}" +
                                    $" {usuario.Apellido} con ID {usuario.ID}");
            }
            catch (Exception ex) 
            { 
                Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado."); 
            }

            return true;
        }


        //Modificacion de los propios datos del usuario cuando esta logueado
        public void modificacionUsuarioActual(int idUsuario, string mail, string password)
        {

            Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");

            usuario.ID = idUsuario;
            usuario.Mail = mail;
            usuario.Password = password;

        }

        // SALA --------------------------------------------------------------------------------------------
        public bool altaSala(string ubicacion, int capacidad)
        {
            //tiene que haber un contructor en sala especial para crearla. El ID se puede generar
            //automaticamente con un atributo estatico en la clase Sala.
            Sala sala = new Sala(ubicacion, capacidad);
            salas.Add(sala);

            Debug.WriteLine($">>> (Cine - altaSala()) Se CREÓ la SALA ubicada en {sala.Ubicacion}" +
                                $" con capacidad para {sala.Capacidad} espectadores");
            return true;
        }
        
        public void bajaSala(int idSala)
        {
            Sala sala = (Sala)obtenerObjetoDeLista(idSala, "sala");
            salas.Remove(sala);
            Debug.WriteLine($">>> Se ELIMINÓ la SALA ubicada en {sala.Ubicacion}" +
                                $" con capacidad para {sala.Capacidad} espectadores");
            sala = null;
        }        

        public bool modificacionSala(int ID, string ubicacion, int capacidad)
        {
            Sala sala = (Sala)obtenerObjetoDeLista(ID, "sala");

            sala.Ubicacion = ubicacion;
            sala.Capacidad = capacidad;
            return true;
        }

        // FUNCION --------------------------------------------------------------------------------------------
         public bool altaFuncion(int idSala, int idPelicula, DateTime fecha, double costo)
         {
            Sala miSala = null;

            foreach (Sala sala in this.salas)
            {
                if (idSala == sala.ID) 
                {
                    miSala = sala;
                    break;                
                }
            }

            Pelicula miPelicula = null;

            foreach(Pelicula pelicula in this.peliculas)
            {
                if (idPelicula == pelicula.ID) 
                {

                    miPelicula = pelicula;
                    break;
                
                }
            }

            if (miPelicula == null || miSala == null)
            {

                return false;

            }
            else
            {

                Funcion funcion = new Funcion(miSala, miPelicula, fecha, 0, costo); //se pasa cero pero no habría que ingresar Cantidad de clientes
                miPelicula.MisFunciones.Add(funcion);
                miSala.MisFunciones.Add(funcion);
                funciones.Add(new Funcion(miSala, miPelicula, fecha, 0, costo));
                Debug.WriteLine($">>> (Cine - altaFuncion()) Se CREÓ la FUNCION en la sala {funcion.MiSala.ID}" +
                                 $" para la película {funcion.MiPelicula.Nombre} en la fecha {funcion.Fecha} con un costo de {funcion.Costo}");
                return true;
            }            
         }

        public bool modificarFuncion(int ID,int idSala,int idPelicula, DateTime fecha, double costo)//
        {

            Sala unaSala = (Sala)obtenerObjetoDeLista(idSala, "sala");
            Pelicula unaPelicula = (Pelicula)obtenerObjetoDeLista(idPelicula, "pelicula");
            Funcion funcion = (Funcion)obtenerObjetoDeLista(ID,"funcion");

            funcion.MiSala = unaSala;
            funcion.MiPelicula = unaPelicula;
            funcion.Fecha = fecha;
            funcion.Costo = costo;


            return true;


        }

        public void bajaFuncion(int idFuncion)
        {
            Funcion funcion= (Funcion)obtenerObjetoDeLista(idFuncion, "funcion");
            funciones.Remove(funcion);
            Debug.WriteLine($">>> (Cine - bajafuncion()) Se dió de baja la FUNCIÓN con ID {funcion.ID}");
            funcion = null;
        }
        // PELICULA -------------------------------------------------------------------------------------------
        public bool altaPelicula(string nombre, string sinopsis, int duracion)
        {

            Pelicula pelicula = new Pelicula(nombre, sinopsis, duracion);
            peliculas.Add(pelicula);

            Debug.WriteLine($">>> (Cine - altaPelicula()) Se creó la PELÍCULA {pelicula.Nombre} con ID {pelicula.ID}");
            return true;
        }

        
        public bool modificarPelicula(int ID, string nombre, string sinopsis, int duracion)
        {

            Pelicula pelicula = (Pelicula)obtenerObjetoDeLista(ID, "pelicula");

            pelicula.Nombre = nombre;
            pelicula.Sinopsis = sinopsis;
            pelicula.Duracion = duracion;
            return true;

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

        public string comprarEntrada(int idUsuario, int idFuncion = -1, int cantidad = 0)
        {
            Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");
            Funcion funcion = (Funcion)obtenerObjetoDeLista(idFuncion, "funcion");

             

            double importe = funcion.Costo * cantidad;
            int entradasDispoibles = funcion.MiSala.Capacidad - funcion.CantClientes;

            if (cantidad == 0) {
                return $"SELECCIONAR ENTRADA : debe seleccionar al menos una ENTRADA";
            }
            else if (idFuncion == -1)
            {
                return $"SELECCIONAR FUNCION: debe seleccionar al menos una FUNCIÓN";
            }
            else if (importe > usuario.Credito)
            {
                Debug.WriteLine($">>> (Cine - comprarEntrada()) CRÉDITO insuficiente para comprar la/s {cantidad} entrada/s");
                return $"CRÉDITO INSUFICIENTE : tiene {usuario.Credito} de crédito no puede comprar {cantidad} entradas a ${importe}";
            }
            else if (entradasDispoibles < cantidad)
            {
                Debug.WriteLine($">>> (Cine - comprarEntrada()) No pueden venderse {cantidad} entradas quedan disponibles {entradasDispoibles}");
                return $"SIN BUTACAS DISPONIBLES : la sala esta completa (capacidad {funcion.MiSala.Capacidad})";
            }
            else
            {
                usuario.Credito -= importe;
                funcion.CantClientes += cantidad;
                Debug.WriteLine($">>> >>> (Cine - comprarEntrada()) VENTA : \n  Cantidad Entradas: {cantidad}" +
                                    $"\n Importe : {importe}\nPrecio entrada : {funcion.Costo}");
                return $"COMPRA REALIZADA : compró {cantidad} entradas a {funcion.Costo} por un importe total de {importe}";
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
        public bool iniciarSesion(string mail, string password)
        {
            string comprobar = "";
            for (int i = 0; i < this.usuarios.Count(); i++)
            {

                //se comprueba MAIL
                if (usuarios[i].Mail == mail)
                {   //se comprueba PASSWORD
                    if (usuarios[i].Password == password)
                    {
                        if (usuarios[i].Bloqueado != true)
                        {
                            this.usuarioActual = usuarios[i];
                            comprobar = "ok";
                            usuarios[i].IntentosFallidos = 0;
                        }
                    }
                    else
                    {
                        usuarios[i].IntentosFallidos++;
                        if (usuarios[i].IntentosFallidos == 4)
                            usuarios[i].Bloqueado = true;
                    }
                }
            }
            if (comprobar == "ok") return true;
            else return false;
        }

        public int intentos(string mail)
        {
            int a = 0;
            for (int i = 0; i < this.usuarios.Count(); i++)
            {
                if (usuarios[i].Mail == mail)
                {
                    if (usuarios[i].Bloqueado == true)
                    {
                        a = 4;
                    }
                    else
                    {
                        a = usuarios[i].IntentosFallidos;
                    }
                }
            }
            return a;
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
        public List<Usuario> mostrarUsuarios()
        {
            return usuarios.ToList();
        }

        
        public List<Funcion> buscarFuncion(DateTime fecha = new DateTime(), string ubicacion = "",
                                            double costo = -1, string pelicula = "")
        {

            List<Funcion> listaDeFunciones = new List<Funcion>();

            for (int i = 0; i < this.funciones.Count; i++) {
                //si la fecha ingresada es igual a al fecha de una funcion y el resto de datos no se ingresó, guarda la Funcion en la lista
                if (this.funciones[i].Fecha == fecha && ubicacion == "" && costo == -1 && pelicula == "")
                { 
                    listaDeFunciones.Add(this.funciones[i]); 
                }
                //si la ubicación ingresada es igual a la ubicación de la sala de la funcion y el resto de datos no se ingresó, guarda la Función en la lista
                else if (fecha.Year == 0 && (ubicacion != "" && funciones[i].MiSala.Ubicacion == ubicacion) && costo == -1 && pelicula == ""){ 
                    listaDeFunciones.Add(funciones[i]); 
                }
                //si el costo ingresado es igual (podria ser <=) al costo de la Funcion y el resto de datos no se ingresó, guarda la Función en la lista
                else if (fecha.Year == 0 && ubicacion == "" && (costo > -1 && this.funciones[i].Costo == costo) && pelicula == ""){ 
                    listaDeFunciones.Add(funciones[i]); 
                }
                else if (fecha.Year == 0 && ubicacion == "" && costo == -1 && (pelicula != "" && funciones[i].MiPelicula.Nombre == pelicula)){ 
                    listaDeFunciones.Add(funciones[i]); 
                }
                else if ((fecha.Year != 0 && funciones[i].Fecha == fecha)&& (ubicacion != "" && funciones[i].MiSala.Ubicacion == ubicacion) && (costo > -1 && funciones[i].Costo == costo) && (pelicula != "" && funciones[i].MiPelicula.Nombre == pelicula)) {
                    listaDeFunciones.Add(funciones[i]);
                }
            }            
            return listaDeFunciones.ToList();
        }

        private object obtenerObjetoDeLista(int ID, string tipoObjeto)
        {
            object objeto = new object();
            
            if (tipoObjeto.ToLower() == "usuario")
            {
                bool idOk = false;
                for (int i = 0; i < usuarios.Count; i++)
                {
                    if (usuarios[i].ID == ID)
                    {
                        objeto = usuarios[i];
                        idOk = true;
                        break;
                    }
                }
                if (idOk == false) { throw new Exception(); }
            }
            else if (tipoObjeto.ToLower() == "sala")
            {
                bool idOk = false;
                for (int i = 0; i < salas.Count; i++)
                {
                    if (salas[i].ID == ID)
                    {
                        objeto = salas[i];
                        break;
                    }
                }
                if (idOk == false) { throw new Exception(); }
            }
            else if (tipoObjeto.ToLower() == "funcion")
            {
                bool idOk = false;
                for (int i = 0; i < funciones.Count; i++)
                {
                    if (funciones[i].ID == ID)
                    {
                        objeto = funciones[i];
                        break;
                    }
                }
                if (idOk == false) { throw new Exception(); }
            }
            else if (tipoObjeto.ToLower() == "pelicula")
            {
                bool idOk = false;
                for (int i = 0; i < peliculas.Count; i++)
                {
                    if (peliculas[i].ID == ID)
                    {
                        objeto = peliculas[i];
                        break;
                    }
                }
                if (idOk == false) { throw new Exception(); }
            }
            else
            { 
                Debug.WriteLine($">>> {this.GetType().Name} No se encontró el objeto solicitado, revise ID y tipo de objeto");
                throw new Exception();
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