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
using Microsoft.EntityFrameworkCore;

namespace TP_grupoA_Cine
{
    public class Cine
    {

        private List<Usuario> usuarios = new List<Usuario>();
        private List<Funcion> funciones = new List<Funcion>();
        private List<Sala> salas = new List<Sala>();
        private List<Pelicula> peliculas = new List<Pelicula>();
        private Usuario UsuarioActual = new Usuario();
        private List<UsuarioFuncion> usFun = new List<UsuarioFuncion>();
        private ControladorDB DB;

        public Usuario usuarioActual() {

            return this.UsuarioActual;
        }

        // SINGLETON -------------------------------------------------------------------------------------------
        private readonly static Cine _instancia = new Cine();

        private MyContext ContextCine;

        private Cine()
        {
            inicializarAtributos();
        }

        private void inicializarAtributos()
        {
            try
            {
                ContextCine = new MyContext();
                ContextCine.usuario.Include(u => u.MisFunciones).Load();
                ContextCine.funcion.Include(f => f.Clientes).Load();
                ContextCine.salas.Include(s => s.MisFunciones).Load();
                ContextCine.peliculas.Include(p => p.MisFunciones).Load();
                ContextCine.UF.Load();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        //   --------------------------------------------------------------------------------------------

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

            try
            {
                Usuario usr = ContextCine.usuario.Where(u => u.DNI == dni && u.Mail == mail).FirstOrDefault();

                if (usr != null)
                {
                    esValido = false;
                }
                if (esValido)
                {
                    Usuario nuevo = new Usuario { DNI = dni, Nombre = nombre, Apellido = apellido, Mail = mail, Password = password, FechaNacimiento = fechaNacimiento, EsAdmin = esAdmin, Bloqueado = false };
                    ContextCine.usuario.Add(nuevo);
                    ContextCine.SaveChanges();
                    Debug.WriteLine($">>> (Cine - altaUsuario()) Se CREÓ el USUARIO {nuevo.Nombre}" +
                                       $" {nuevo.Apellido} con ID {nuevo.ID}");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool eliminarUsuario(int Id)
        {
            try
            {
                Usuario usr = ContextCine.usuario.Where(u => u.ID == Id).FirstOrDefault();
                if (usr != null) {
                    ContextCine.usuario.Remove(usr);
                    ContextCine.SaveChanges();
                    return true;
                }
                else {
                    return false;
                }
            } catch (Exception) {
                return false;
            }
        }

        public bool modificarUsuario(int idUsuarioModif, int dni, string nombre, string apellido, string mail, string password, DateTime fechaNacimiento, bool esAdmin, bool bloqueado)
        {

            Usuario usr = ContextCine.usuario.Where(u => u.ID == idUsuarioModif).FirstOrDefault();
            if (usr != null)

            {
                usr.Nombre = nombre;
                usr.Apellido = apellido;
                usr.Mail = mail;
                usr.Password = password;
                usr.FechaNacimiento = fechaNacimiento;
                usr.EsAdmin = esAdmin;
                usr.Bloqueado = bloqueado;
                ContextCine.usuario.Update(usr);
                ContextCine.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
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
            Sala miSala = (Sala)obtenerObjetoDeLista(idSala, "sala");
            Pelicula miPelicula = (Pelicula)obtenerObjetoDeLista(idPelicula, "pelicula");

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

        public bool modificarFuncion(int ID, int idSala, int idPelicula, DateTime fecha, double costo)//
        {
            try
            {
                Sala unaSala = (Sala)obtenerObjetoDeLista(idSala, "sala");
                Pelicula unaPelicula = (Pelicula)obtenerObjetoDeLista(idPelicula, "pelicula");
                Funcion funcion = (Funcion)obtenerObjetoDeLista(ID, "funcion");

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

        // TRANSACCIONES --------------------------------------------------------------------------------------

        public void cargarCredito(int idUsuario, double importe)
        {
            double creditoNuevo = usuarioActual().Credito + importe;
            if (DB.cargarCreditoDB(idUsuario, creditoNuevo) == 1)
            {
                try
                {
                    usuarioActual().Credito += importe;
                    Debug.WriteLine($">>> (Cine - cargarCredito()) Se CARGARON $ {importe} quedando el CRÉDITO en {usuarioActual().Credito} ID usuario : {usuarioActual().ID}");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado. Mensaje de error : " + ex);
                }
            }
            else
            {
                Debug.WriteLine(">>> Cine -- cargarCredito : No se cargó el CRÉDITO en la base de datos y tampoco en el objeto USUARIO");
            }

        }

        public string comprarEntrada(int idUsuario, int idFuncion, int cantidad)
        {
            string mensaje = "";
            Debug.WriteLine("linea 524" + cantidad);
            try
            {
                Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");
                Funcion funcion = (Funcion)obtenerObjetoDeLista(idFuncion, "funcion");


                double importe = funcion.Costo * cantidad;
                int entradasDispoibles = funcion.MiSala.Capacidad - funcion.CantClientes;
                Debug.WriteLine("linea 534" + cantidad);

                if (importe > usuario.Credito)
                {
                    Debug.WriteLine($">>> (Cine - comprarEntrada()) CRÉDITO insuficiente para comprar la/s {cantidad} entrada/s");
                    mensaje = $"CRÉDITO INSUFICIENTE : tiene {usuario.Credito} de crédito no puede comprar {cantidad} entradas a ${importe}";
                }
                else if (entradasDispoibles < cantidad)
                {
                    Debug.WriteLine($">>> (Cine - comprarEntrada()) No pueden venderse {cantidad} entradas quedan disponibles {entradasDispoibles}");
                    mensaje = $"SIN BUTACAS DISPONIBLES : la sala esta completa (capacidad {funcion.MiSala.Capacidad})";
                }
                else
                {
                    bool usFunOk = false;

                    foreach (UsuarioFuncion usuarioFuncion in usFun)
                    {
                        if (usuarioFuncion.idUsuario == idUsuario && usuarioFuncion.idFuncion == idFuncion)
                        {
                            usFunOk = true;

                        }
                    }

                    if (usFunOk == true) //VALIDA SI EL USUARIO YA TIENE COMPRADAS FUNCIONES
                    {
                        //COMPRA MAS FUNCIONES DE LAS QUE YA COMPRO ANTERIORMENTE
                        if (DB.comprarEntradaUpdateDB(idUsuario, idFuncion, cantidad, importe) == 1)
                        {
                            UsuarioFuncion unUsFun = (UsuarioFuncion)obtenerObjetoDeLista(idUsuario, idFuncion);

                            usuario.Credito -= importe;
                            funcion.CantClientes += cantidad;

                            unUsFun.cantidadCompra += cantidad;

                            Debug.WriteLine($">>> >>> (Cine - comprarEntrada()) VENTA : \n  Cantidad Entradas: {cantidad}" +
                                                $"\n Importe : {importe}\nPrecio entrada : {funcion.Costo}");

                            mensaje = $"COMPRA REALIZADA : compró {cantidad} entradas a {funcion.Costo} por un importe total de {importe}";
                        }
                    }
                    else
                    {
                        Debug.WriteLine(">>>Cine - comprarEntrada() : este usuario no tiene entradas compradas para esta FUNCIÓN");
                        //COMPRA DE 0
                        if (DB.comprarEntradaDB(idUsuario, idFuncion, cantidad, funcion.Costo) == 1)
                        {
                            usuario.Credito -= importe;
                            usuario.MisFunciones.Add(funcion);

                            funcion.Clientes.Add(usuario);
                            funcion.CantClientes += cantidad;

                            UsuarioFuncion objetoUsuarioFuncion = new UsuarioFuncion(usuario, funcion, cantidad);
                            usFun.Add(objetoUsuarioFuncion);

                            Debug.WriteLine($">>> >>> (Cine - comprarEntrada()) VENTA : \n  Cantidad Entradas: {cantidad}" +
                                                $"\n Importe : {importe}\nPrecio entrada : {funcion.Costo}");

                            mensaje = $"COMPRA REALIZADA : compró {cantidad} entradas a {funcion.Costo} por un importe total de {importe}";
                        }
                        else
                        {
                            Debug.WriteLine($"No se a podido ingresar la compra (ID USUARIO : {idUsuario} ID FUNDION : {idFuncion})");
                            mensaje = "No se a podido ingresar la compra";
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado." + ex);
            }

            return mensaje;
        }

        public bool mostrarFuncionesUsuario(int idUsuario, int idFuncion, int cantidad, int idSala, int idPelicula, DateTime fecha, double costo)
        {
            Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");
            Funcion funcion = (Funcion)obtenerObjetoDeLista(idFuncion, "funcion");

            return true;// Prueba
        }

        public string devolverEntrada(int idUsuario, int idFuncion, int cantidad) //se agreaga idFuncion (no esta en UML)
        {
            Debug.WriteLine(">>> Cine - devolverEntrada() : ingreso al método devolverEntrada()");
            string mensaje = "";

            // foreach de usuario funcion para buscar la compra del cliente
            // se compara la cantidad comprada por el cliente (en la tabla usuarioFuncion)
            // si e s igual a l cantidad que devuelve el cliente eS DELETE si no UPDATE

            try
            {
                Debug.WriteLine(">>> Cine - devolverEntrada() : ingreso a primer TRY");
                UsuarioFuncion unUsFun = (UsuarioFuncion)obtenerObjetoDeLista(idUsuario, idFuncion);
                Funcion miFuncion = unUsFun.MiFuncion;
                Debug.WriteLine(">>> Cine - devolverEntrada() : ID USUARIO " + idUsuario + " ID FUNCION " + idFuncion);

                double monto = miFuncion.Costo * cantidad;

                if (unUsFun.cantidadCompra < cantidad)
                {
                    Debug.WriteLine($"Cine -- devolverEntrada() : Se esta intentando devolver una cantidad de entradas MAYOR a la que se compró.");
                    mensaje = "Cine -- devolverEntrada() : Se esta intentando devolver una cantidad de entradas MAYOR a la que se compró.";
                }
                else if (DateTime.Compare(miFuncion.Fecha, DateTime.UtcNow) < 0)
                {
                    mensaje = $"No puede devolver una entrada anterior a la fecha actual {DateTime.UtcNow.ToString("MM-dd-yyyy")}";
                }
                else if (unUsFun.cantidadCompra == cantidad)
                {
                    if (DB.DeleteDevolverEntradaDB(idUsuario, idFuncion, monto, cantidad) == 1)
                    {
                        Debug.WriteLine(">>> Cine - devolverEntrada() : ingreso a DELETE");
                        try
                        {
                            Debug.WriteLine(">>> Cine - devolverEntrada() : ingreso a TRY del DELETE");
                            Usuario usuario = (Usuario)obtenerObjetoDeLista(idUsuario, "usuario");

                            //Ahora sí lo elimino en la lista
                            Debug.WriteLine($">>> Cine - eliminarEntrada() : ID USUARIO : " + usuario.ID + " APELLIDO USUARIO : " + usuario.Apellido);
                            Debug.WriteLine($">>> Cine - eliminarEntrada() : ID FUNCION : " + miFuncion.ID + " PELICULA FUNCION : " + miFuncion.MiPelicula.Nombre);

                            usuario.Credito += monto;         //se reintegra SALDO al CLIENTE
                            miFuncion.CantClientes -= cantidad;   //se descuentan las ENTRADAS devueltas

                            //de la CANTIDAD DE CLIENTE en al FUNCION
                            miFuncion.Clientes.Remove(usuario);
                            usuario.MisFunciones.Remove(miFuncion);


                            mensaje = $"Se a devuelto la totalidad de su dinero por la devolución de entradas (Entradas : {cantidad} Dinero devuelto : {monto})";

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Clase {this.GetType().Name} Mensaje de error : " + ex);
                        }
                    }
                    else
                    {
                        mensaje = $"No se a podido realizar la devolución";
                        //algo salió mal con la query porque no generó 1 registro
                        Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado.");
                    }

                    return mensaje;

                }
                else
                {
                    if (DB.UpdateDevolverEntradaDB(idUsuario, idFuncion, cantidad, monto) == 1)
                    {

                        Usuario usuario = unUsFun.MiUsuario;
                        Funcion funcion = unUsFun.MiFuncion;

                        usuario.Credito += monto;
                        unUsFun.cantidadCompra -= cantidad;
                        funcion.CantClientes -= cantidad;

                        Debug.WriteLine($">>> (Cine - devolderEntrada()) VENTA : \n  Cantidad Entradas: {cantidad}" + $"\n Importe : {monto}\nPrecio entrada : {funcion.Costo}");

                        mensaje = $"DEVOLUCIÓN REALIZADA : se reintegraron {cantidad} por un valor de ${miFuncion.Costo} cada una y un importe total de {monto}";
                    }
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado.");
            }

            return mensaje;
        }

        // SESION --------------------------------------------------------------------------------------------

        //se ingresa como ARGUMENTOS mail y password desde FORM
        public bool iniciarSesion(string mail, string password)
        {
            try
            {
                string comprobar = "";
                Usuario usr = ContextCine.usuario.Where(u => u.Mail == mail).FirstOrDefault();
                //Debug.WriteLine(">>> Cine -- iniciarSesion() : " + usr.Nombre);

                if (usr != null)
                {
                    if (usr.Bloqueado != false)// Aca se rompe el monitor
                    {
                        if (usr.Password == password)
                        {
                            this.UsuarioActual = usr;
                            comprobar = "ok";
                            usr.IntentosFallidos = 0;
                            ContextCine.usuario.Update(usr);
                            ContextCine.SaveChanges();
                        }
                        else
                        {
                            usr.IntentosFallidos++;
                            if (usr.IntentosFallidos == 4)
                            {
                                usr.Bloqueado = true;
                                ContextCine.usuario.Update(usr);
                                ContextCine.SaveChanges();
                            }
                        }
                    }else
                    {
                        //USUARIO BLOQUEADO
                    }
                }
                else
                {
                    return false;
                }

                if (comprobar == "ok") return true;
                else return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public int intentos(string mail)
        {
            Usuario usr = ContextCine.usuario.Where(u => u.Mail == mail).FirstOrDefault();
            int a = 0;
            if (usr != null)
            {
                if (usr.Bloqueado == true)
                {
                    a = 4;
                }
                else
                {
                    a = usr.IntentosFallidos;
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
            List<Funcion> filtroFunciones = new List<Funcion>();
            foreach (Funcion funcion in funciones)
            {
                if (DateTime.Compare(funcion.Fecha.Date, DateTime.UtcNow.Date) >= 0)//Valida que solo se muestren funciones de HOY en adelante.
                {
                    filtroFunciones.Add(funcion);
                }
            }
            return filtroFunciones.ToList();
        }
        public List<Sala> mostrarSalas()
        {
            return ContextCine.salas.ToList();
        }
        public List<Pelicula> mostrarPeliculas()
        {
            return ContextCine.peliculas.ToList();
        }
        public List<Usuario> mostrarUsuarios()
        {
            return ContextCine.usuario.ToList();
        }
        public List<UsuarioFuncion> mostrarUsuarioFuncion() 
        {
            return ContextCine.UF.ToList();           
        }
        public List<Funcion> mostrarMisFunciones()
        {
            return usuarioActual().MisFunciones.ToList();
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

        public object obtenerObjetoDeLista(int idUsuario, int idFuncion)
        {
            Debug.WriteLine("Cine -- obtenerObjetoDeLista(id, id) : ");

            object objeto = new object();
            
            bool idOk = false;
            for (int i = 0; i < usFun.Count; i++)
            {
                if (usFun[i].idUsuario == idUsuario && usFun[i].idFuncion == idFuncion)
                {
                    objeto = usFun[i];
                    idOk = true;
                    break;
                }
            }
            if (idOk == false) { throw new Exception(); }

            return objeto;
        }
    }
}