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
                ContextCine.usuarios.Include(u => u.MisFunciones).Load();
                ContextCine.funciones.Include(f => f.Clientes).Load();
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
                Usuario usr = ContextCine.usuarios.Where(u => u.DNI == dni && u.Mail == mail).FirstOrDefault();

                if (usr != null)
                {
                    esValido = false;
                }
                if (esValido)
                {
                    Usuario nuevo = new Usuario { DNI = dni, Nombre = nombre, Apellido = apellido, Mail = mail, Password = password, FechaNacimiento = fechaNacimiento, EsAdmin = esAdmin, Bloqueado = false };
                    ContextCine.usuarios.Add(nuevo);
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
                Usuario usr = ContextCine.usuarios.Where(u => u.ID == Id).FirstOrDefault();
                if (usr != null) {
                    ContextCine.usuarios.Remove(usr);
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

            Usuario usr = ContextCine.usuarios.Where(u => u.ID == idUsuarioModif).FirstOrDefault();
            if (usr != null)

            {
                usr.Nombre = nombre;
                usr.Apellido = apellido;
                usr.Mail = mail;
                usr.Password = password;
                usr.FechaNacimiento = fechaNacimiento;
                usr.EsAdmin = esAdmin;
                usr.Bloqueado = bloqueado;
                ContextCine.usuarios.Update(usr);
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

            try
            {
                Sala nuevo = new Sala { Ubicacion = ubicacion, Capacidad = capacidad };

                ContextCine.salas.Add(nuevo);
                ContextCine.SaveChanges();
                Debug.WriteLine($">>> (Cine - altaSala()) Se CREÓ la SALA ubicada en {nuevo.Ubicacion}" +
                                $" con capacidad para {nuevo.Capacidad} espectadores");
                return true;
            }
            catch (Exception ex)
            {
                //algo salió mal con la query porque no generó un id válido
                Debug.WriteLine(ex);
                return false;
            }
            
            
        }

        public bool bajaSala(int idSala)
        {
            
                try
                {
                    Sala sala = ContextCine.salas.Where(s => s.ID == idSala).FirstOrDefault();
                    
                       
                    if (sala != null)
                    {
                        ContextCine.salas.Remove(sala);
                        ContextCine.SaveChanges();
                        Debug.WriteLine($">>> Se ELIMINÓ la SALA ubicada en {sala.Ubicacion}" +
                                $" con capacidad para {sala.Capacidad} espectadores");
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

        public bool modificacionSala(int idSala, string ubicacion, int capacidad)
        {
            
                try
                {
                    Sala sala = ContextCine.salas.Where(s => s.ID == idSala).FirstOrDefault();

                    if (sala !=  null)
                    {
                        sala.Ubicacion = ubicacion;
                        sala.Capacidad = capacidad;
                        ContextCine.salas.Update(sala);
                        ContextCine.SaveChanges();

                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(">>>Cine : modificarSala() : " + ex);
                    return false;
                }         
        }

        // FUNCION --------------------------------------------------------------------------------------------
        public bool altaFuncion(int idSala, int idPelicula, DateTime fecha, double costo)
        {
            try
            {
                Sala nuevaSala = ContextCine.salas.Where(s => s.ID == idSala).FirstOrDefault();
                Pelicula nuevaPelicula = ContextCine.peliculas.Where(p => p.ID == idPelicula).FirstOrDefault();

                if (nuevaSala == null || nuevaPelicula == null)
                {

                    Debug.WriteLine(">>>Cine -- altaFuncion : no se encontró alguno de los objetos SALA, PELICULA o ambos");
                    return false;

                }
                else
                {
                    Funcion nuevaFuncion = new Funcion { MiSala = nuevaSala, MiPelicula = nuevaPelicula, Fecha = fecha, Costo = costo }; //se pasa cero pero no habría que ingresar Cantidad de clientes

                    nuevaSala.MisFunciones.Add(nuevaFuncion);
                    nuevaPelicula.MisFunciones.Add(nuevaFuncion);
                    ContextCine.funciones.Add(nuevaFuncion);
                    ContextCine.SaveChanges();

                    Debug.WriteLine($">>> (Cine - altaFuncion()) Se CREÓ la FUNCION en la sala {nuevaFuncion.MiSala.ID}" +
                                 $" para la película {nuevaFuncion.MiPelicula.Nombre} en la fecha {nuevaFuncion.Fecha} con un costo de {nuevaFuncion.Costo}");
                    return true;
                }
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>> Cine - altaFuncion() : " + ex);
                return false;
            }
        }
            
        public bool modificarFuncion(int ID, int idSala, int idPelicula, DateTime fecha, double costo)//
        {
            try
            {
                    Sala unaSala = ContextCine.salas.Where(s => s.ID == idSala).FirstOrDefault();
                    Pelicula unaPelicula = ContextCine.peliculas.Where(p => p.ID == idPelicula).FirstOrDefault();
                    Funcion funcion = ContextCine.funciones.Where(f => f.ID == ID).FirstOrDefault();

                    if (unaSala != null && unaPelicula != null && funcion != null) 
                    {
                        funcion.MiSala = unaSala;
                        funcion.MiPelicula = unaPelicula;
                        funcion.Fecha = fecha;
                        funcion.Costo = costo;

                        ContextCine.funciones.Update(funcion);
                        ContextCine.SaveChanges();

                        return true;
                    }
                    else
                    {
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
           
                try
                {
                    Funcion funcion = ContextCine.funciones.Where(f => f.ID == ID).FirstOrDefault();
            //Ahora sí lo elimino en la lista

            if (funcion != null)
                        {
                            ContextCine.funciones.Remove(funcion);
                            ContextCine.SaveChanges();
                            return true;
                        }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
           
        }

        // PELICULA -------------------------------------------------------------------------------------------

        public bool altaPelicula(string nombre, string sinopsis, int duracion, string poster)
        {
            try
            {
                Pelicula nuevo = new Pelicula { Nombre = nombre, Sinopsis = sinopsis, Duracion = duracion, Poster = poster };
                ContextCine.peliculas.Add(nuevo);
                ContextCine.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine($">>> Cine - altaPelicula() : {ex}");
                return false;
            }

            
        }

        public bool modificarPelicula(int id, string Nombre, string Sinopsis, int Duracion, string Poster)
        {
            
           
                try
                {
                    Pelicula pelicula = ContextCine.peliculas.Where(p => p.ID == id).FirstOrDefault();
            //Ahora sí lo MODIFICO en la lista

            if (pelicula != null)
                    {
                        pelicula.Nombre = Nombre;
                        pelicula.Sinopsis = Sinopsis;
                        pelicula.Duracion = Duracion;
                        pelicula.Poster = Poster;
                        ContextCine.peliculas.Update(pelicula);
                        ContextCine.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(">>>Cine : modificarPelicula : " + ex);
                    return false;
                }
            
        }

        public bool bajaPelicula(int id)
        {
            //primero me aseguro que lo pueda agregar a la base
            
            try
            {
                  Pelicula pelicula = ContextCine.peliculas.Where(p => p.ID == id).FirstOrDefault();
                //Ahora sí lo elimino en la lista
                
                    if (pelicula != null)
                    {
                        ContextCine.peliculas.Remove(pelicula);
                        ContextCine.SaveChanges();
                        return true;
                    }
                    else
                        return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($">>> Cine - bajaPelicula() : {ex}");
                return false;
            }
            
        }

        // TRANSACCIONES --------------------------------------------------------------------------------------

        public void cargarCredito(int idUsuario, double importe)
        {
            double creditoNuevo = usuarioActual().Credito + importe;
 
                try
                {
                    Usuario usuario = ContextCine.usuarios.Where(u => u.ID == usuarioActual().ID).FirstOrDefault();

                    if (usuario != null)
                    {
                        usuario.Credito = creditoNuevo;
                        ContextCine.usuarios.Update(usuario);
                        ContextCine.SaveChanges();

                        Debug.WriteLine($">>> (Cine - cargarCredito()) Se CARGARON $ {importe} quedando el CRÉDITO en {usuario.Credito} ID usuario : {usuario.ID}");
                    }
                    
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado. Mensaje de error : " + ex);
                }
            
        }

        public string comprarEntrada(int idUsuario, int idFuncion, int cantidad)
        {
            string mensaje = "";
            
            try
            {
                Usuario usuario = ContextCine.usuarios.Where(u => u.ID == idUsuario).FirstOrDefault();
                Funcion funcion = ContextCine.funciones.Where(f => f.ID == idFuncion).FirstOrDefault();

                double importe;
                int entradasDispoibles;

                if (usuario != null && funcion != null)
                {
                    UsuarioFuncion usuarioFuncion = ContextCine.UF.Where(uf => uf.idUsuario == idUsuario && uf.idFuncion == idFuncion).FirstOrDefault();

                    importe = funcion.Costo * cantidad;
                    entradasDispoibles = funcion.MiSala.Capacidad - funcion.CantClientes;

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
                        if (usuarioFuncion != null)// Compra si el usuario tiene funciones compradas
                        {
                            funcion.CantClientes += cantidad;
                            usuario.Credito -= importe;
                            usuarioFuncion.cantidadCompra += cantidad;

                            ContextCine.UF.Update(usuarioFuncion);
                            ContextCine.funciones.Update(funcion);
                            ContextCine.usuarios.Update(usuario);
                            ContextCine.SaveChanges();

                            Debug.WriteLine($">>> >>> (Cine - comprarEntrada()) VENTA : \n  Cantidad Entradas: {cantidad}" +
                                               $"\n Importe : {importe}\nPrecio entrada : {funcion.Costo}");

                            mensaje = $"COMPRA REALIZADA : compró {cantidad} entradas a {funcion.Costo} por un importe total de {importe}";
                        }
                        else //Compra de 0
                        {
                            Debug.WriteLine(">>>Cine - comprarEntrada() : este usuario no tiene entradas compradas para esta FUNCIÓN");

                            UsuarioFuncion UF = new UsuarioFuncion { MiUsuario = usuario, MiFuncion = funcion, cantidadCompra = cantidad};
                            
                            Debug.WriteLine($"Cine - comprarEntrada : arg idUsuario -> {idUsuario} arg idFuncion -> {idFuncion}");

                            usuario.MisFunciones.Add(funcion);
                            usuario.Credito -= importe;
                            funcion.Clientes.Add(usuario);
                            funcion.CantClientes += cantidad;
                            ContextCine.UF.Add(UF);
                            ContextCine.usuarios.Update(usuario);
                            ContextCine.funciones.Update(funcion);
                            ContextCine.SaveChanges();

                            Debug.WriteLine($">>> >>> (Cine - comprarEntrada()) VENTA : \n  Cantidad Entradas: {cantidad}" +
                                                $"\n Importe : {importe}\nPrecio entrada : {funcion.Costo}\n ID Usuario : {usuario.ID}");

                            mensaje = $"COMPRA REALIZADA : compró {cantidad} entradas a {funcion.Costo} por un importe total de {importe}";
                        }

                    }

                }
                else
                {
                    Debug.WriteLine($"No se a podido ingresar la compra (ID USUARIO : {idUsuario} ID FUNDION : {idFuncion})");
                    mensaje = "No se a podido ingresar la compra";
                }
            }catch (Exception ex)
            {
                Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado." + ex);
            }
            return mensaje;
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
                Usuario usuario = ContextCine.usuarios.Where(u => u.ID == idUsuario).FirstOrDefault();
                Funcion funcion = ContextCine.funciones.Where(f => f.ID == idFuncion).FirstOrDefault();

                if (usuario != null && funcion != null)
                {
                    UsuarioFuncion UF = ContextCine.UF.Where(uf => uf.idUsuario == idUsuario && uf.idFuncion == idFuncion).FirstOrDefault();
                    double monto = funcion.Costo * cantidad;

                    if (UF != null)
                    {

                        if (DateTime.Compare(funcion.Fecha.Date, DateTime.UtcNow) > 0) //Revisamos si devuelve entradas con fecha superior a la del dia de hoy o no
                        {
                            if (UF.cantidadCompra == cantidad) //devuelve todas las entradas que compro (cantidad = a la cantidad que compro)
                            {
                                usuario.Credito += monto;
                                funcion.CantClientes -= cantidad;
                                usuario.MisFunciones.Remove(funcion);
                                funcion.Clientes.Remove(usuario);

                                ContextCine.usuarios.Update(usuario);
                                ContextCine.funciones.Update(funcion);
                                ContextCine.UF.Remove(UF);
                                ContextCine.SaveChanges();

                                mensaje = $"Se a devuelto la totalidad de su dinero por la devolución de entradas (Entradas : {cantidad} Dinero devuelto : {monto})";
                            }
                            else if (UF.cantidadCompra > cantidad)//devuelve algunas (cantidad menor a la que habia comprado)
                            {
                                UF.cantidadCompra -= cantidad;
                                usuario.Credito += monto;
                                funcion.CantClientes -= cantidad;

                                ContextCine.usuarios.Update(usuario);
                                ContextCine.funciones.Update(funcion);
                                ContextCine.UF.Update(UF);
                                ContextCine.SaveChanges();

                                mensaje = $"DEVOLUCIÓN REALIZADA : se reintegraron {cantidad} por un valor de ${funcion.Costo} cada una y un importe total de {monto}";
                            }
                            else //Quiere devolver de mas (cantidad mayor a la cantidad que compro)
                            {
                                Debug.WriteLine($"Cine -- devolverEntrada() : Se esta intentando devolver una cantidad de entradas MAYOR a la que se compró.");
                                mensaje = "Cine -- devolverEntrada() : Se esta intentando devolver una cantidad de entradas MAYOR a la que se compró.";
                            }
                        }
                        else
                        {
                            mensaje = $"No puede devolver una entrada anterior a la fecha actual {DateTime.UtcNow.ToString("MM-dd-yyyy")}";
                        }
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
                Usuario usr = ContextCine.usuarios.Where(u => u.Mail == mail && u.Bloqueado == false).FirstOrDefault();
                //Debug.WriteLine(">>> Cine -- iniciarSesion() : " + usr.Nombre);

                if (usr != null)
                {
                        if (usr.Password == password)
                        {
                            this.UsuarioActual = usr;
                            comprobar = "ok";
                            usr.IntentosFallidos = 0;
                            ContextCine.usuarios.Update(usr);
                            ContextCine.SaveChanges();
                        }
                        else
                        {
                            usr.IntentosFallidos++;
                            if (usr.IntentosFallidos == 4)
                            {
                                usr.Bloqueado = true;
                                ContextCine.usuarios.Update(usr);
                                ContextCine.SaveChanges();
                            }
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
            Usuario usr = ContextCine.usuarios.Where(u => u.Mail == mail).FirstOrDefault();
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
            Debug.WriteLine(">>> Cine - mosterarFunciones : se crea lista");

            IEnumerable<Funcion> listaFunciones = 
               from funcion in ContextCine.funciones
               where funcion.Fecha.Date >= DateTime.UtcNow.Date
               select funcion;

            Debug.WriteLine(">>> Cine - mosterarFunciones : se devuelve lista");
            return listaFunciones.ToList();
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
            return ContextCine.usuarios.ToList();
        }
        public List<UsuarioFuncion> mostrarUsuarioFuncion() 
        {
            return ContextCine.UF.ToList();           
        }
        public List<Funcion> mostrarMisFunciones()
        {
            return usuarioActual().MisFunciones.ToList();
        }       
    }
}