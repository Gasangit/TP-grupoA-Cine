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

        private List<Usuario> usuarios = new List<Usuario>();
        private List<Funcion> funciones = new List<Funcion>();
        private List<Sala> salas = new List<Sala>();
        private List<Pelicula> peliculas = new List<Pelicula>();
        private Usuario UsuarioActual = new Usuario();
        private ControladorDB DB;



        public Usuario usuarioActual() {

            return this.UsuarioActual;
        }
        // SINGLETON -------------------------------------------------------------------------------------------
        private readonly static Cine _instancia = new Cine();

        private Cine() {
            DB = new ControladorDB();
            usuarios = DB.llenarListaUsuarios();
            salas = DB.llenarListaSala();
            peliculas = DB.llenarListaPelicula();
            funciones = DB.llenarListaFuncion();
        }

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
                                   DateTime fechaNacimiento, bool esAdmin, bool bloqueado)
        {

            //comprobación para que no me agreguen usuarios con DNI duplicado
            bool esValido = true;
            foreach (Usuario u in usuarios)
            {
                if (u.DNI == dni)
                    esValido = false;
            }

            if (dni.ToString().Length != 8 && dni.ToString().Length != 7) 
               
            {
                MessageBox.Show("Difiere la cantidad de digitos en el DNI. Deben ser 8 o 7 digitos"); 
            
            }

                
            if (esValido)
            {
                int NewUser;
                NewUser = DB.altaUsuarioDB(dni, nombre, apellido, mail, password, fechaNacimiento , esAdmin, bloqueado);
                if (NewUser != -1)
                {
                    //Ahora sí lo agrego en la lista
                    //la clase Usuario tiene que tener un constructor para el ALTA
                    Usuario nuevo = new Usuario(NewUser, dni, nombre, apellido, mail, password, fechaNacimiento, esAdmin, false, 0.0);
                    //el ID se puede generar automaticamente con un atributo estatico en la clase Usuario
                    usuarios.Add(nuevo);
                    Debug.WriteLine($">>> (Cine - altaUsuario()) Se CREÓ el USUARIO {nuevo.Nombre}" +
                                       $" {nuevo.Apellido} con ID {nuevo.ID}");
                    return true;
                }
                else
                {
                    //algo salió mal con la query porque no generó un id válido
                    return false;
                }
            }
            else
                return false;

        }

        public bool eliminarUsuario(int Id)
        {
            //primero me aseguro que lo pueda agregar a la base
            if (DB.eliminarUsuarioDB(Id) == 1)
            {
                try
                {
                    //Ahora sí lo elimino en la lista
                    foreach (Usuario u in usuarios)
                        if (u.ID == Id)
                        {
                            usuarios.Remove(u);
                            return true;
                        }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                //algo salió mal con la query porque no generó 1 registro
                return false;
            }
        }

        public bool modificarUsuario(int id, int dni, string nombre, string apellido, string mail, string password, DateTime fechaNacimiento, bool esAdmin, bool bloqueado)
        {
            //primero me aseguro que lo pueda agregar a la base
            if (DB.modificarUsuarioDB(id, dni, nombre, apellido, mail, password, fechaNacimiento, esAdmin, bloqueado) == 1)
            {
                try
                {
                    //Ahora sí lo MODIFICO en la lista
                    for (int i = 0; i < usuarios.Count; i++)
                        if (usuarios[i].ID == id)
                        {
                            usuarios[i].Nombre = nombre;
                            usuarios[i].Apellido = apellido;
                            usuarios[i].Mail = mail;
                            usuarios[i].Password = password;
                            usuarios[i].FechaNacimiento = fechaNacimiento;
                            usuarios[i].EsAdmin = esAdmin;
                            usuarios[i].Bloqueado = bloqueado;
                        }
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(">>>Cine : modificarUsuario : " + ex);
                    return false;
                }
            }
            else
            {
                //algo salió mal con la query porque no generó 1 registro
                return false;
            }
        }
        
        //Modificacion de los propios datos del usuario cuando esta logueado
        public bool modificacionUsuarioActual(int idUsuario, string mail, string password, string nombre, string apellido, int dni, DateTime fechaNacimiento)
        {
            //primero me aseguro que lo pueda agregar a la base
            bool esAdmin = usuarios[idUsuario].EsAdmin;
            bool bloqueado = usuarios[idUsuario].Bloqueado;
          
                    if (DB.modificarUsuarioDB(idUsuario,dni, nombre, apellido, mail, password, fechaNacimiento, esAdmin, bloqueado)==1)
            {
                try
                {
                    //Ahora sí lo MODIFICO en la lista
                    Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");
                    {
                            usuario.Nombre = nombre;
                            usuario.Apellido = apellido;
                            usuario.Mail = mail;
                            usuario.Password = password;
                            usuario.FechaNacimiento = fechaNacimiento;
                            usuario.EsAdmin = esAdmin;
                            usuario.Bloqueado = bloqueado;
                        }
                    return true;
                }
                catch (Exception)
                {
                    Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado.");
                    return false;
                }
            }
            else
            {
                //algo salió mal con la query porque no generó 1 registro
                return false;
            }


          try
            {
                Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");

                usuario.ID = idUsuario;
                usuario.Mail = mail;
                usuario.Password = password;
                usuario.Nombre = nombre;
                usuario.DNI = dni;
                usuario.Apellido = apellido;
                usuario.FechaNacimiento = fechaNacimiento;
            }
            catch (Exception ex) 
            {
                
            }

            return true;
        }

        // SALA --------------------------------------------------------------------------------------------
        public bool altaSala(string ubicacion, int capacidad)
        {
            //tiene que haber un contructor en sala especial para crearla. El ID se puede generar
            //automaticamente con un atributo estatico en la clase Sala.
            int NewSala;
            NewSala = DB.altaSalaDB(ubicacion, capacidad);
            if (NewSala != -1)
            {
               
                Sala nuevo = new Sala(NewSala, ubicacion, capacidad);
                
                salas.Add(nuevo);
                Debug.WriteLine($">>> (Cine - altaSala()) Se CREÓ la SALA ubicada en {nuevo.Ubicacion}" +
                                $" con capacidad para {nuevo.Capacidad} espectadores");
                return true;
            }
            else
            {
                //algo salió mal con la query porque no generó un id válido
                return false;
            }
        }
        
        public bool bajaSala(int idSala)
        {
            //primero me aseguro que lo pueda agregar a la base
            if (DB.eliminarSalaDB(idSala) == 1)
            {
                try
                {
                    //Ahora sí lo elimino en la lista
                    foreach (Sala s in salas)
                        if (s.ID == idSala)
                        {
                            salas.Remove(s);
                            Debug.WriteLine($">>> Se ELIMINÓ la SALA ubicada en {s.Ubicacion}" +
                                 $" con capacidad para {s.Capacidad} espectadores");
                            return true;
                        }
                    return false;
                }
                catch (Exception)
                {
                    Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado.");
                    return false;
                }
            }
            else
            {
                //algo salió mal con la query porque no generó 1 registro
                return false;
            }

        }        

        public bool modificacionSala(int ID, string ubicacion, int capacidad)
        {
            if (DB.modificarSalaDB(ID, ubicacion, capacidad) == 1)
            {
                try
                {
                    //Ahora sí lo MODIFICO en la lista
                    for (int i = 0; i < salas.Count; i++)
                        if (salas[i].ID == ID)
                        {
                            salas[i].Ubicacion = ubicacion;
                            salas[i].Capacidad = capacidad;                    
                        }
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(">>>Cine : modificarSala : " + ex);
                    return false;
                }
            }
            else
            {
                //algo salió mal con la query porque no generó 1 registro
                Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado.");
                return false;
            }
        }

        // FUNCION --------------------------------------------------------------------------------------------
         public bool altaFuncion(int idSala, int idPelicula, DateTime fecha, double costo)
         {
            Sala miSala = (Sala) obtenerObjetoDeLista(idSala, "sala");
            Pelicula miPelicula = (Pelicula) obtenerObjetoDeLista(idPelicula, "pelicula");

            if (miPelicula == null || miSala == null)
            {
                Debug.WriteLine(">>>Cine -- altaFuncion : no se encontró alguno de los objetos SALA, PELICULA o ambos");
                return false;

            }
            else
            {
                int idNuevaFuncion = DB.altaFuncionDB(idSala, idPelicula, fecha, costo);
                if (idNuevaFuncion != -1)
                {
                    Funcion funcion = new Funcion(idNuevaFuncion, miSala, miPelicula, fecha, costo); //se pasa cero pero no habría que ingresar Cantidad de clientes
                    miPelicula.MisFunciones.Add(funcion);
                    miSala.MisFunciones.Add(funcion);
                    funciones.Add(new Funcion(idNuevaFuncion, miSala, miPelicula, fecha, costo));
                    Debug.WriteLine($">>> (Cine - altaFuncion()) Se CREÓ la FUNCION en la sala {funcion.MiSala.ID}" +
                                     $" para la película {funcion.MiPelicula.Nombre} en la fecha {funcion.Fecha} con un costo de {funcion.Costo}");
                    return true;
                }
                else
                {
                    Debug.WriteLine("Cine -- altaFuncion : no se a podido CREAR la FUNCION. No se ingresó a la base de datos");
                    return false;
                } 
            }    
         }

        public bool modificarFuncion(int ID,int idSala,int idPelicula, DateTime fecha, double costo)//
        {
            try 
            {
                Sala unaSala = (Sala) obtenerObjetoDeLista(idSala, "sala");
                Pelicula unaPelicula = (Pelicula) obtenerObjetoDeLista(idPelicula, "pelicula");
                Funcion funcion = (Funcion) obtenerObjetoDeLista(ID, "funcion");

                if (DB.modificarFuncionesDB(ID, idSala, idPelicula, fecha, costo) == 1)
                {
                    funcion.MiSala = unaSala;
                    funcion.MiPelicula = unaPelicula;
                    funcion.Fecha = fecha;
                    funcion.Costo = costo;

                    return true;
                }
                else 
                {
                    Debug.WriteLine(">>>Cine -- modificarFuncion : no se a podido MODIFICAR la FUNCION");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Clase {this.GetType().Name} modificarFuncion >>> OBJETO o ID no encontrado.");
                return false;
            }
        }

        public bool bajaFuncion(int ID)
        {
            //primero me aseguro que lo pueda agregar a la base
            if (DB.eliminarFuncionesDB(ID) == 1)
            {
                try
                {
                    //Ahora sí lo elimino en la lista
                    foreach (Funcion f in funciones)
                        if (f.ID == ID)
                        {
                            funciones.Remove(f);
                            return true;
                        }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                //algo salió mal con la query porque no generó 1 registro
                return false;
            }
        }

       /* public void bajaFuncion(int idFuncion)
        {
            try
            {
                Funcion funcion = (Funcion)obtenerObjetoDeLista(idFuncion, "funcion");
                funciones.Remove(funcion);
                Debug.WriteLine($">>> (Cine - bajafuncion()) Se dió de baja la FUNCIÓN con ID {funcion.ID}");
                funcion = null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado.");
            }
        }*/
        // PELICULA -------------------------------------------------------------------------------------------



        public bool altaPelicula(string nombre, string sinopsis, int duracion, string poster)
        {
                int idNuevaPelicula;
                idNuevaPelicula = DB.altaPeliculaDB(nombre, sinopsis, duracion, poster);
                if (idNuevaPelicula != -1)
                {
                    //Ahora sí lo agrego en la lista
                    //la clase Pelicula tiene que tener un constructor para el ALTA
                    Pelicula nuevo = new Pelicula(idNuevaPelicula, nombre, sinopsis, duracion, poster);
                    //el ID se puede generar automaticamente con un atributo estatico en la clase Pelicula
                    peliculas.Add(nuevo);
                   
                    return true;
                }
                else
                {
                    //algo salió mal con la query porque no generó un id válido
                    return false;
                }
        }
      /*  public bool altaPelicula(string nombre, string sinopsis, int duracion, string poster)
        {

            Pelicula pelicula = new Pelicula(nombre, sinopsis, duracion, poster);
            peliculas.Add(pelicula);

            Debug.WriteLine($">>> (Cine - altaPelicula()) Se creó la PELÍCULA {pelicula.Nombre} con ID {pelicula.ID}");
            return true;
        }*/

        
        public bool modificarPelicula(int id, string Nombre, string Sinopsis, int Duracion, string Poster)
        {

            if (DB.modificarPeliculaDB(id, Nombre, Sinopsis, Duracion, Poster) == 1)
            {
                try
                {
                    //Ahora sí lo MODIFICO en la lista
                    for (int i = 0; i < peliculas.Count; i++)
                        if (peliculas[i].ID == id)
                        {
                            peliculas[i].Nombre = Nombre;
                            peliculas[i].Sinopsis = Sinopsis;
                            peliculas[i].Duracion = Duracion;
                            peliculas[i].Poster = Poster;
                        }
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(">>>Cine : modificarPelicula : " + ex);
                    return false;
                }
            }
            else
            {
                //algo salió mal con la query porque no generó 1 registro
                Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado.");
                return false;
            }


            //try
            //{
            //    pelicula pelicula = (pelicula)obtenerobjetodelista(id, "pelicula");

            //    pelicula.nombre = nombre;
            //    pelicula.sinopsis = sinopsis;
            //    pelicula.duracion = duracion;
            //}
            //catch (exception ex)
            //{
            //    debug.writeline($"clase {this.gettype().name} >>> objeto o id no encontrado.");
            //}

            //return true;
        }

        public bool bajaPelicula(int id)
        {
            //primero me aseguro que lo pueda agregar a la base
            if (DB.eliminarPeliculaDB(id) == 1)
            {
                try
                {
                    //Ahora sí lo elimino en la lista
                    foreach (Pelicula p in peliculas)
                        if (p.ID == id)
                        {
                            peliculas.Remove(p);
                            return true;
                        }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                //algo salió mal con la query porque no generó 1 registro
                return false;
            }
        }

       /* public void bajaPelicula(int idPelicula)
        {
            try 
            {
                Pelicula pelicula = (Pelicula)obtenerObjetoDeLista(idPelicula, "pelicula");
                peliculas.Remove(pelicula);
                Debug.WriteLine($">>> (Cine - bajaPelicula()) Se dió de baja la PELÍCULA {pelicula.Nombre} con ID {pelicula.ID}");
                pelicula = null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado.");
            }
        }*/

        // TRANSACCIONES --------------------------------------------------------------------------------------

        public void cargarCredito(int idUsuario, double importe)
        {
            try
            {
                Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");
                usuario.Credito += importe;
                Debug.WriteLine($">>> (Cine - cargarCredito()) Se CARGARON $ {importe} quedando el CRÉDITO en {usuario.Credito} ID usuario : {usuario.ID}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado.");
            }
        }

        public string comprarEntrada(int idUsuario, int idFuncion, int cantidad)
        {
            string mensaje = "";
            Debug.WriteLine(cantidad);
            try
            {
                Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");
                Funcion funcion = (Funcion)obtenerObjetoDeLista(idFuncion, "funcion");

                double importe = funcion.Costo * cantidad;
              ///  int entradasDispoibles = funcion.MiSala.Capacidad - funcion.CantClientes;

                if (importe > usuario.Credito)
                {
                    Debug.WriteLine($">>> (Cine - comprarEntrada()) CRÉDITO insuficiente para comprar la/s {cantidad} entrada/s");
                    mensaje = $"CRÉDITO INSUFICIENTE : tiene {usuario.Credito} de crédito no puede comprar {cantidad} entradas a ${importe}";
                }
              //  else if (entradasDispoibles < cantidad)
              //  {
              //      Debug.WriteLine($">>> (Cine - comprarEntrada()) No pueden venderse {cantidad} entradas quedan disponibles {entradasDispoibles}");
              ///      mensaje = $"SIN BUTACAS DISPONIBLES : la sala esta completa (capacidad {funcion.MiSala.Capacidad})";
              //  }
                else
                {
                    usuario.Credito -= importe;
                    usuario.MisFunciones.Add(funcion);

                //    funcion.CantClientes += cantidad;
                    funcion.Clientes.Add(usuario);

                    Debug.WriteLine($">>> >>> (Cine - comprarEntrada()) VENTA : \n  Cantidad Entradas: {cantidad}" +
                                        $"\n Importe : {importe}\nPrecio entrada : {funcion.Costo}");
                    mensaje = $"COMPRA REALIZADA : compró {cantidad} entradas a {funcion.Costo} por un importe total de {importe}";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado.");
            }

            return mensaje;
        }

        public bool mostrarFuncionesUsuario(int idUsuario,int idFuncion, int cantidad, int idSala, int idPelicula, DateTime fecha, double costo)
        {
            Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");
            Funcion funcion = (Funcion)obtenerObjetoDeLista(idFuncion, "funcion");

            // Funcion funcion = usuario.MisFunciones[idFuncion];

            // double importe = funcion.Costo * cantidad;
            return true;// Prueba
        }


        public void devolverEntrada(int idUsuario,int idFuncion, int cantidad) //se agreaga idFuncion (no esta en UML)
        {
            try 
            {
                //la cantidad de entrada que compra el cliente para un funcion no queda
                //guardada en ningun lugar. Puede comprar 2 y pedir que le devuelvan 4.
                Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");
                Funcion funcion = usuario.MisFunciones[idFuncion]; //en el UML no esta pero el método
                                                                   //tendría que tener un ID de Funcion

                double importe = funcion.Costo * cantidad;// el IMPORTE a devolver por las entradas es el
                                                          // COSTO de la FUNCION por la CANTIDAD de entradas
                usuario.Credito += importe;         //se reintegra SALDO al CLIENTE
            //    funcion.CantClientes -= cantidad;   //se descuentan las ENTRADAS devueltas
                                                    //de la CANTIDAD DE CLIENTE en al FUNCION
                funcion.Clientes.Remove(usuario);
                usuario.MisFunciones.Remove(funcion);
                Debug.WriteLine($">>> VENTA : \n  Cantidad Entradas: {cantidad}" +
                                    $"\n Importe : {importe}\nPrecio entrada : {funcion.Costo}");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado.");
            }

        }

        // SESION --------------------------------------------------------------------------------------------

        //se ingresa como ARGUMENTOS mail y password desde FORM
        public bool iniciarSesion(string mail, string password)
        {
            usuarios = DB.llenarListaUsuarios();

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
                            this.UsuarioActual = usuarios[i];
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
            this.UsuarioActual = null;
        }

        // FRONT --------------------------------------------------------------------------------------------

        /*  recordar que las listas se tienen que devolver (return) con el método ToList() para no
            devolver la lista original y que la misma no sea modificada.    */
        public List<Funcion> mostrarFunciones() 
        {
            funciones = DB.llenarListaFuncion();
            return funciones.ToList();
        }
        public List<Sala> mostrarSalas()
        {
            salas = DB.llenarListaSala();
            return salas.ToList();
        }
        public List<Pelicula> mostrarPeliculas()
        {
            peliculas = DB.llenarListaPelicula();
            return peliculas.ToList();
        }
        public List<Usuario> mostrarUsuarios()
        {
            usuarios = DB.llenarListaUsuarios();
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

        public object obtenerObjetoDeLista(int ID, string tipoObjeto)
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
                        idOk = true;
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
                        idOk = true;
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
                        idOk = true;
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