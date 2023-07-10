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

        //LLena el usuario conectado actualmente a la app
        public Usuario usuarioActual() {

            return this.UsuarioActual;
        }

        // SINGLETON -------------------------------------------------------------------------------------------
        //Instanacia privada de Cine para que no se copie (para que exista una sola en toda la app)
        private readonly static Cine _instancia = new Cine();

        //Se declara el contexto
        private MyContext ContextCine;

        //Constructor de Cine carga los DBSet e inicializa el contexto
        private Cine()
        {
            inicializarAtributos();
        }

        //Hace lo descripto en el constructor. Carga datos de base en memoria e inicializa el contexto
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

        //metodo para obtener la instancia privada desde otras clases (por ejemplo las vistas)
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

            //comprobación para que no se agreguen usuarios con DNI y MAIL duplicados
            bool esValido = true;

            try // controla que no falle la instanciación del objeto
            {
                Usuario usr = ContextCine.usuarios.Where(u => u.DNI == dni && u.Mail == mail).FirstOrDefault();

                if (usr != null)
                {
                    esValido = false;
                }
                if (esValido)
                {
                    Usuario nuevo = new Usuario { DNI = dni, Nombre = nombre, Apellido = apellido, Mail = mail, Password = password, FechaNacimiento = fechaNacimiento, EsAdmin = esAdmin, Bloqueado = false };

                    ContextCine.usuarios.Add(nuevo); //se ageraga al contexto
                    ContextCine.SaveChanges(); // se guarda en base de datos

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
                List<UsuarioFuncion> usuarioFuncion = ContextCine.UF.Where(uf => uf.idUsuario == Id).ToList();
                foreach (UsuarioFuncion uf in usuarioFuncion)
                {

                    if (uf.MiFuncion.Fecha >= DateTime.Now)
                    {
                        uf.MiUsuario.Credito += uf.cantidadCompra * uf.MiFuncion.Costo;
                        ContextCine.usuarios.Update(uf.MiUsuario);
                        ContextCine.SaveChanges();
                    }

                }

                Usuario usr = ContextCine.usuarios.Where(u => u.ID == Id).FirstOrDefault();

                if (usr != null)
                {
                    ContextCine.usuarios.Remove(usr);//se remuve del contexto
                    ContextCine.SaveChanges();//se guarda en la base de datos
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool modificarUsuario(int idUsuarioModif, int dni, string nombre, string apellido, string mail, string password, DateTime fechaNacimiento, bool esAdmin, bool bloqueado)
        {
            //Se busca el usuario por ID
            Usuario usr = ContextCine.usuarios.Where(u => u.ID == idUsuarioModif).FirstOrDefault();

            if (usr != null)

            {   //modificamos los atributos del objeto para actualizarlo en el contexto
                usr.Nombre = nombre;
                usr.Apellido = apellido;
                usr.Mail = mail;
                usr.Password = password;
                usr.FechaNacimiento = fechaNacimiento;
                usr.EsAdmin = esAdmin;
                usr.Bloqueado = bloqueado;
                ContextCine.usuarios.Update(usr);//se actualiza desde el contexto
                ContextCine.SaveChanges();//se guarda en la base de datos
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
                IEnumerable<Funcion> misFunciones = sala.MisFunciones.Where(funcion => funcion.Fecha >= DateTime.Now);

                if (sala != null && misFunciones == null)
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

                if (sala != null)
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
                //Se buscan los objetos sala y pelicula comprobando si existen
                Sala nuevaSala = ContextCine.salas.Where(s => s.ID == idSala).FirstOrDefault();
                Pelicula nuevaPelicula = ContextCine.peliculas.Where(p => p.ID == idPelicula).FirstOrDefault();

                if (nuevaSala == null || nuevaPelicula == null)
                {

                    Debug.WriteLine(">>>Cine -- altaFuncion : no se encontró alguno de los objetos SALA, PELICULA o ambos");
                    return false;

                }
                else // si existen sala y pelicula se crea la funcion
                {
                    Funcion nuevaFuncion = new Funcion { MiSala = nuevaSala, MiPelicula = nuevaPelicula, Fecha = fecha, Costo = costo }; 

                    nuevaSala.MisFunciones.Add(nuevaFuncion); //se agrega funcion a la sala
                    nuevaPelicula.MisFunciones.Add(nuevaFuncion); //se agrega funcion a pelicula
                    ContextCine.funciones.Add(nuevaFuncion); // se agraga funcion al contexto
                    ContextCine.salas.Update(nuevaSala);
                    ContextCine.peliculas.Update(nuevaPelicula);
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
                //Se controla si existen FUNCION, SALA y PELICULA en la función a modificar              

                Funcion funcion = ContextCine.funciones.Where(f => f.ID == ID).FirstOrDefault();

                if (funcion.MiSala.ID != idSala)
                {
                    Sala unaSala = ContextCine.salas.Where(s => s.ID == idSala).FirstOrDefault();
                    funcion.MiSala.MisFunciones.Remove(funcion);
                    funcion.MiSala = unaSala;
                    unaSala.MisFunciones.Add(funcion);
                    ContextCine.salas.Update(unaSala);
                }

                if (funcion.MiPelicula.ID != idPelicula)
                {
                    Pelicula unaPelicula = ContextCine.peliculas.Where(p => p.ID == idPelicula).FirstOrDefault();
                    funcion.MiPelicula.MisFunciones.Remove(funcion);
                    funcion.MiPelicula = unaPelicula;
                    unaPelicula.MisFunciones.Add(funcion);
                    ContextCine.peliculas.Update(unaPelicula);
                }

                if (funcion != null)
                {

                    funcion.Fecha = fecha;
                    funcion.Costo = costo;

                    //al hacer UPDATE de la funcion se actualiza la listas de funciones en SALA y PELICULA
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

                /*PROFE PIDIO DEVOLVER DINERO A TODOS LOS CLIENTES SI BAJO UNA FUNCION
                if(funcion.Fecha > DateTime.Now)
                {
                    foreach(Usuario u in funcion.Clientes)
                    {
                        UsuarioFuncion uf = ContextCine.UF.Where(uf=>uf.idUsuario == u.ID && uf.idFuncion == funcion.ID).FirstOrDefault();
                        u.Credito += funcion.Costo * uf.cantidadCompra;
                        ContextCine.usuarios.Update(u);                   
                    }

                }
                */
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
            catch (Exception ex)
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

            usuarioActual().Credito = creditoNuevo;
            ContextCine.usuarios.Update(usuarioActual());
            ContextCine.SaveChanges();

            Debug.WriteLine($">>> (Cine - cargarCredito()) Se CARGARON $ {importe} quedando el CRÉDITO en {usuarioActual().Credito} ID usuario : {usuarioActual().ID}");        
        }

        public string comprarEntrada(int idUsuario, int idFuncion, int cantidad) //Se puede hacer con UF
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
                    // Se busca en tabla intermedia para ver si existe la relacion usuario / funcion (si existe el clietne tiene entradas)
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
                            funcion.CantClientes += cantidad; //se suman clientes a al objeto funcion
                            usuario.Credito -= importe; //se resta dinero al objeto usuario
                            usuarioFuncion.cantidadCompra += cantidad;//se agrega la cantidad en el objeto para la tabla intermedia 

                            ContextCine.UF.Update(usuarioFuncion); //Se actualiza usuario funcion, ya que se agregaron mas cantidades de entradas compradas
                            ContextCine.funciones.Update(funcion);//Se actualiza funcion para restar la cantidad de entradas disponibles para una funcion
                            ContextCine.usuarios.Update(usuario); //se actualiza usuario para restar crédito
                            ContextCine.SaveChanges();

                            Debug.WriteLine($">>> >>> (Cine - comprarEntrada()) VENTA : \n  Cantidad Entradas: {cantidad}" +
                                               $"\n Importe : {importe}\nPrecio entrada : {funcion.Costo}");

                            mensaje = $"COMPRA REALIZADA : compró {cantidad} entradas a {funcion.Costo} por un importe total de {importe}";
                        }
                        else //Compra de 0
                        {
                            Debug.WriteLine(">>>Cine - comprarEntrada() : este usuario no tiene entradas compradas para esta FUNCIÓN");

                            UsuarioFuncion UF = new UsuarioFuncion { MiUsuario = usuario, MiFuncion = funcion, cantidadCompra = cantidad };

                            Debug.WriteLine($"Cine - comprarEntrada : arg idUsuario -> {idUsuario} arg idFuncion -> {idFuncion}");

                            usuario.MisFunciones.Add(funcion); //Al usuario se le agrega la funcion que compro a su lista de funciones
                            usuario.Credito -= importe; //Resto credito al usuario
                            funcion.Clientes.Add(usuario); //A la funcion se le agrega el usuario a la lista de CLientes
                            funcion.CantClientes += cantidad;// A la funcion se se le agrega la cantidad de cliente que compraron esa funcion                    
                            ContextCine.UF.Add(UF); // Se agrega las relacion entre el usuario y las funciones
                            ContextCine.usuarios.Update(usuario); //Se actualiza el usuario restandole credito
                            ContextCine.funciones.Update(funcion); //Se actualiza la funcion restando disponibilidad de la sala
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
                    mensaje = "No se a podido ingresar la compra"; //Mensaje que se pasa a la vista
                }
            } catch (Exception ex)
            {
                Debug.WriteLine($"Clase {this.GetType().Name} >>> OBJETO o ID no encontrado." + ex);
            }
            return mensaje; //se pasa a la vista
        }


        public string devolverEntrada(int idUsuario, int idFuncion, int cantidad) //se agreaga idFuncion (no esta en UML)
        {
            Debug.WriteLine(">>> Cine - devolverEntrada() : ingreso al método devolverEntrada()");
            string mensaje = "";           

            try
            {
                Usuario usuario = ContextCine.usuarios.Where(u => u.ID == idUsuario).FirstOrDefault();
                Funcion funcion = ContextCine.funciones.Where(f => f.ID == idFuncion).FirstOrDefault();

                if (usuario != null && funcion != null)
                {
                    UsuarioFuncion UF = ContextCine.UF.Where(uf => uf.idUsuario == idUsuario && uf.idFuncion == idFuncion).FirstOrDefault();
                    double monto = funcion.Costo * cantidad; //El monto corresponde al costo de la funcion X la cantidad a devolver

                    if (UF != null)
                    {

                        if (DateTime.Compare(funcion.Fecha.Date, DateTime.UtcNow) > 0) //Revisamos si devuelve entradas con fecha superior a la del dia de hoy o no
                        {
                            if (UF.cantidadCompra == cantidad) //devuelve todas las entradas que compro (cantidad = a la cantidad que compro)
                            {
                                usuario.Credito += monto; //Le suma el monto (cantidad devuelta x costo) al usuario
                                funcion.CantClientes -= cantidad; //Resta la cantidad de clientes en al funcion
                                usuario.MisFunciones.Remove(funcion); //Elimina la funcion de la lista de funciones del usuario
                                funcion.Clientes.Remove(usuario);  //Elimina al usuario de la lista de clientes de la funcion

                                ContextCine.usuarios.Update(usuario); //Actualiza el contexto de usaurio porque cambio el credito
                                ContextCine.funciones.Update(funcion); //Actualiza el contexto de funcion porque cambio la disponibilidad
                                ContextCine.UF.Remove(UF); //Elimina la usuario-funcion (ya que se devolvio todo)
                                ContextCine.SaveChanges();

                                mensaje = $"Se a devuelto la totalidad de su dinero por la devolución de entradas (Entradas : {cantidad} Dinero devuelto : {monto})";
                            }
                            else if (UF.cantidadCompra > cantidad)//devuelve algunas (cantidad menor a la que habia comprado)
                            {
                                UF.cantidadCompra -= cantidad; //Resta en la relacion la cantidad de entradas entre usuario y funciones
                                usuario.Credito += monto; //Le suma el monto (cantidad devuelta x costo) al usuario
                                funcion.CantClientes -= cantidad; // Resta la cantidad de clientes en la funcion

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
                if (usr != null)
                {
                    if (usr.Password == password)
                    {
                        this.UsuarioActual = usr;
                        comprobar = "ok";
                        usr.IntentosFallidos = 0;
                        ContextCine.usuarios.Update(usr);//Actualiza los intentos fallidos a 0
                        ContextCine.SaveChanges();
                    }
                    else
                    {
                        usr.IntentosFallidos++;
                        if (usr.IntentosFallidos == 4)
                        {
                            usr.Bloqueado = true;
                        }
                        ContextCine.usuarios.Update(usr);
                        ContextCine.SaveChanges();
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

        public int intentos(string mail)//Esto es para la vista
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
                    a = usr.IntentosFallidos;//Se actualiza el número de "a" dependiendo el numero de intentos
                }
            }
            return a; //dependiendo el número de "a" ingresa en un message del switch distinto en la vista
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
               where funcion.Fecha.Date >= DateTime.UtcNow.Date // Filtro de funciones
               select funcion;

           Debug.WriteLine(">>> Cine - mosterarFunciones : se devuelve lista");
            return listaFunciones.ToList();
        }

        public List<Funcion> mostrarFuncionesFiltradas(string pelicula, string sala, double costo, DateTime fecha)
        {

            IEnumerable<Funcion> funcionesFiltradas = ContextCine.funciones;


            //Entra solamante en los if que no dan null (es decir que se seleccionaron en la vista)
            if (pelicula != "")
            {
                funcionesFiltradas = funcionesFiltradas.Where(f => f.MiPelicula.Nombre == pelicula);
            }

            if (sala != "")
            {
                funcionesFiltradas = funcionesFiltradas.Where(f => f.MiSala.Ubicacion == sala);
            }

            if (costo != 0)
            {
                funcionesFiltradas = funcionesFiltradas.Where(f => f.Costo == costo);
            }

            if (fecha.Date >= DateTime.UtcNow.Date)
            {
                funcionesFiltradas = funcionesFiltradas.Where(f => f.Fecha == fecha);
            }

            return funcionesFiltradas.ToList();
        }

        public List<Funcion> mostrarFuncionesXSala(int sala)
        {
            return ContextCine.salas.Where(s => s.ID == sala).FirstOrDefault().MisFunciones.ToList();
/*
            IEnumerable<Funcion> funcionXSala = ContextCine.funciones;
            if (sala != 0)
            {
                funcionXSala = funcionXSala.Where(fs => fs.MiSala.ID == sala);
            }
            return funcionXSala.ToList();
*/
        }

        public List<Funcion> mostrarFuncionesXPelicula(int pelicula)
        {

            return ContextCine.peliculas.Where(p => p.ID == pelicula).FirstOrDefault().MisFunciones.ToList();
                
            /*

            IEnumerable<Funcion> funcionXPelicula = ContextCine.funciones;

            if (pelicula != 0)
            {

                funcionXPelicula = funcionXPelicula.Where(fp => fp.MiPelicula.ID == pelicula);

            }

            return funcionXPelicula.ToList();
            */
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

        public List<UsuarioFuncion> mostrarFuncionesDelUsuario(int usId)
        {

            return usuarioActual().UsuarioFuncion.ToList();

           // IEnumerable<UsuarioFuncion> funcionesUsuario = ContextCine.UF;

           // funcionesUsuario = funcionesUsuario.Where(uf => uf.idUsuario == usId);

           // return funcionesUsuario.ToList();

        }
        
    }
}