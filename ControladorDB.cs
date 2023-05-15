using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace TP_grupoA_Cine
{
    class ControladorDB
    {
        private string connectionString;
        Cine cine = Cine.Instancia;

        public ControladorDB()
        {
            //Cargo la cadena de conexión desde el archivo de properties
            connectionString = Properties.Resources.ConnectionStr;
        }

        #region Usuarios
        public List<Usuario> llenarListaUsuarios()
        {
            List<Usuario> misUsuarios = new List<Usuario>();

            //Generamos el sting con el select de la tabla usuarios
            string consulta = "SELECT * FROM Usuarios";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Definimos el comando a enviar al motor SQL con la consulta y la conexión
                SqlCommand command = new SqlCommand(consulta, connection);
                try
                {
                    //Abrimos la conexion
                    connection.Open();
                    //mi objecto DataReader va a obtener los resultados de la consulta, notar que a comando se le pide ExecuteReader()
                    SqlDataReader reader = command.ExecuteReader();
                    Usuario user;
                    //mientras haya registros/filas en mi DataReader, sigo leyendo
                    while (reader.Read())
                    {
                        user = new Usuario(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetBoolean(7), reader.GetBoolean(8), reader.GetDouble(9));
                        misUsuarios.Add(user);
                    }
                    //En este punto ya recorrí todas las filas del resultado de la query
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return misUsuarios;
        }

        #region AltaUsuario 
        public int altaUsuarioDB(int Dni, string Nombre, string Apellido, string Mail, string Password, DateTime FechaDeNacimiento, bool EsADM, bool Bloqueado)
        {
            //Confirmamos que podamos agregar el registro a la base de datos
            int resultadoQuery;
            int idNuevoUsuario = -1;
            string queryString = "INSERT INTO [dbo].[Usuarios] ([dniUsuario],[nombreUsuario],[apellidoUsuario],[mailUsuario],[passwordUsuario],[fechaNacimiento],[esAdmin],[bloqueado]) VALUES (@dni,@nombre,@apellido,@mail,@password,@fechaNacimiento,@esadm, @bloqueado);";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                //Configuramos los datos que se insertan para no recibir inyecciones sql
                SqlCommand command = new SqlCommand(queryString, connection);
                System.Diagnostics.Debug.WriteLine(">>>ControladorDB : --- " + command.ToString());
                command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@apellido", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@mail", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@fechaNacimiento", SqlDbType.Date));
                command.Parameters.Add(new SqlParameter("@esadm", SqlDbType.Bit));
                command.Parameters.Add(new SqlParameter("@bloqueado", SqlDbType.Bit));

                //Se llenan los parametros con los datos de los argumentos
                command.Parameters["@dni"].Value = Dni;
                command.Parameters["@nombre"].Value = Nombre;
                command.Parameters["@apellido"].Value = Apellido;
                command.Parameters["@mail"].Value = Mail;
                command.Parameters["@password"].Value = Password;
                command.Parameters["@fechaNacimiento"].Value = FechaDeNacimiento;
                command.Parameters["@esadm"].Value = EsADM;
                command.Parameters["@bloqueado"].Value = Bloqueado;

                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    resultadoQuery = command.ExecuteNonQuery();

                    //Query para Obtener el ID que la base nos entrego
                    string ConsultaID = "SELECT MAX([idUsuario]) FROM [dbo].[Usuarios]";
                    System.Diagnostics.Debug.WriteLine(" >>>CONTROLADORDB : ùltimo ID ingresado : " + ConsultaID);
                    command = new SqlCommand(ConsultaID, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    idNuevoUsuario = reader.GetInt32(0);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(">>>ControladorDb -- Excepción ALTA USUARIO : " + ex.Message);
                    return -1;
                }
                return idNuevoUsuario;
            }
        }
        #endregion
        #region Eliminar Usuario
        public int eliminarUsuarioDB(int ID)
        {
            string connectionString = Properties.Resources.ConnectionStr;
            string consulta = "DELETE FROM [dbo].[Usuarios] WHERE idUsuario=@idusuario";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                command.Parameters.Add(new SqlParameter("@idusuario", SqlDbType.Int));
                command.Parameters["@idusuario"].Value = ID;
                try
                {
                    connection.Open();

                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return 0;
                }
            }
        }
        #endregion
        #region Modificar Usuario
        public int modificarUsuarioDB(int id, int Dni, string Nombre, string Apellido, string Mail, string Password, DateTime FechaDeNacimiento, bool EsADM, bool Bloqueado)
        {
            string connectionString = Properties.Resources.ConnectionStr;
            string queryString = "UPDATE [dbo].[Usuarios] SET dniUsuario = @dni, nombreUsuario=@nombre, apellidoUsuario = @apellido, mailUsuario=@mail,passwordUsuario=@password, fechaNacimiento = @fechaNac, esAdmin=@esadm, bloqueado=@bloqueado WHERE idUsuario=@idusuario;";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@idusuario", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@apellido", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@mail", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@fechaNac", SqlDbType.Date));
                command.Parameters.Add(new SqlParameter("@esadm", SqlDbType.Bit));
                command.Parameters.Add(new SqlParameter("@bloqueado", SqlDbType.Bit));
                command.Parameters["@idusuario"].Value = id;
                command.Parameters["@dni"].Value = Dni;
                command.Parameters["@nombre"].Value = Nombre;
                command.Parameters["@apellido"].Value = Apellido;
                command.Parameters["@mail"].Value = Mail;
                command.Parameters["@password"].Value = Password;
                command.Parameters["@fechaNac"].Value = FechaDeNacimiento;
                command.Parameters["@esadm"].Value = EsADM;
                command.Parameters["@bloqueado"].Value = Bloqueado;
                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return 0;
                }
            }
        }
        #endregion

        #endregion Final region Usuarios

        #region Pelicula
        public List<Pelicula> llenarListaPelicula()
        {
            List<Pelicula> misPeliculas = new List<Pelicula>();

            string consulta = "SELECT * FROM Peliculas";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Pelicula peli;
                    while (reader.Read())
                    {
                        peli = new Pelicula(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetString(4));
                        misPeliculas.Add(peli);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return misPeliculas;
        }

        #region Alta Pelicula
        public int altaPeliculaDB(string Nombre, string Sinopsis, int Duracion, string Poster)
        {
            //Confirmamos que podamos agregar el registro a la base de datos
            int resultadoQuery;
            int idNuevaPelicula = -1;
            string queryString = "INSERT INTO [dbo].[Peliculas] ([nombrePelicula],[sinopsisPelicula],[duracionPelicula],[posterPelicula]) VALUES (@nombre,@sinopsis,@duracion,@poster);";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                //Configuramos los datos que se insertan para no recibir inyecciones sql
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@sinopsis", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@duracion", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@poster", SqlDbType.NVarChar));

                //Se llenan los parametros con los datos de los argumentos
                command.Parameters["@nombre"].Value = Nombre;
                command.Parameters["@sinopsis"].Value = Sinopsis;
                command.Parameters["@duracion"].Value = Duracion;
                command.Parameters["@poster"].Value = Poster;

                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    resultadoQuery = command.ExecuteNonQuery();

                    //Query para Obtener el ID que la base nos entrego
                    string ConsultaID = "SELECT MAX([idPelicula]) FROM [dbo].[Peliculas]";
                    command = new SqlCommand(ConsultaID, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    idNuevaPelicula = reader.GetInt32(0);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return -1;
                }
                return idNuevaPelicula;
            }
        }
        #endregion
        #region Eliminar Pelicula
        public int eliminarPeliculaDB(int ID)
        {
            string connectionString = Properties.Resources.ConnectionStr;
            string consulta = "DELETE FROM [dbo].[Peliculas] WHERE idPelicula = @idPelicula";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                command.Parameters.Add(new SqlParameter("@idPelicula", SqlDbType.Int));
                command.Parameters["@idPelicula"].Value = ID;
                try
                {
                    connection.Open();

                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return 0;
                }
            }
        }
        #endregion
        #region Modificar Pelicula
        public int modificarPeliculaDB(int id, string Nombre, string Sinopsis, int Duracion, string Poster)
        {
            string connectionString = Properties.Resources.ConnectionStr;
            string queryString = "UPDATE [dbo].[Peliculas] SET nombrePelicula = @nombrePelicula, sinopsisPelicula=@sinopsisPelicula, duracionPelicula = @duracionPelicula, posterPelicula=@posterPelicula WHERE idPelicula = @idPelicula;";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@idPelicula", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@nombrePelicula", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@sinopsisPelicula", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@duracionPelicula", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@posterPelicula", SqlDbType.NVarChar));
                command.Parameters["@idPelicula"].Value = id;
                command.Parameters["@nombrePelicula"].Value = Nombre;
                command.Parameters["@sinopsisPelicula"].Value = Sinopsis;
                command.Parameters["@duracionPelicula"].Value = Duracion;
                command.Parameters["@posterPelicula"].Value = Poster;
                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return 0;
                }
            }
        }
        #endregion
        #endregion Fin Peliculas

        #region Funciones
        public List<Funcion> llenarListaFuncion()
        {
            List<Funcion> misFunciones = new List<Funcion>();
            List<Sala> salas = llenarListaSala();
            List<Pelicula> peliculas = llenarListaPelicula();

            string consulta = "SELECT * FROM Funciones";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Funcion fun;

                    Cine cine = Cine.Instancia;
                    Sala miSala = new Sala();
                    Pelicula miPelicula = new Pelicula();

                    while (reader.Read())
                    {
                        int idSala = reader.GetInt32(3);
                        int idPelicula = reader.GetInt32(4);

                        foreach (Sala sala in salas)
                        {
                            if(sala.ID == idSala)
                            {
                                miSala = sala;
                            }
                        }

                        foreach (Pelicula pelicula in peliculas)
                        {
                            if (pelicula.ID == idPelicula)
                            {
                                miPelicula = pelicula;
                            }
                        }

                        fun = new Funcion(reader.GetInt32(0), miSala, miPelicula, reader.GetDateTime(1), reader.GetDouble(2));
                        misFunciones.Add(fun);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return misFunciones;
        }

        #region Alta Funcion
        public int altaFuncionDB(int idSala, int idPelicula, DateTime fecha, double costo)
        {
            //Confirmamos que podamos agregar el registro a la base de datos
            int resultadoQuery;
            int idNuevaFuncion = -1;
            string queryString = "INSERT INTO [dbo].[Funciones] ([fechaFuncion],[costoFuncion],[idSala],[idPelicula]) VALUES (@fecha,@costo,@idSala,@idPelicula);";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                //Configuramos los datos que se insertan para no recibir inyecciones sql
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime));
                command.Parameters.Add(new SqlParameter("@costo", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@idSala", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@idPelicula", SqlDbType.Int));


                //Se llenan los parametros con los datos de los argumentos
                command.Parameters["@fecha"].Value = fecha;
                command.Parameters["@costo"].Value = costo;
                command.Parameters["@idSala"].Value = idSala;
                command.Parameters["@idPelicula"].Value = idPelicula;
                

                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    resultadoQuery = command.ExecuteNonQuery();

                    //Query para Obtener el ID que la base nos entrego
                    string ConsultaID = "SELECT MAX([idFuncion]) FROM [dbo].[Funciones]";
                    command = new SqlCommand(ConsultaID, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    idNuevaFuncion = reader.GetInt32(0);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return -1;
                }
                return idNuevaFuncion;
            }
        }
        #endregion
        #region Eliminar Funcion
        public int eliminarFuncionesDB(int ID)
        {
            string connectionString = Properties.Resources.ConnectionStr;
            string consulta = "DELETE FROM [dbo].[Funciones] WHERE idFuncion=@idFuncion";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                command.Parameters.Add(new SqlParameter("@idFuncion", SqlDbType.Int));
                command.Parameters["@idFuncion"].Value = ID;
                try
                {
                    connection.Open();

                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return 0;
                }
            }
        }
        #endregion
        #region Modificar Funcion
        public int modificarFuncionesDB(int ID, int idSala, int idPelicula, DateTime fecha, double costo)
        {
            string connectionString = Properties.Resources.ConnectionStr;
            string queryString = "UPDATE [dbo].[Funciones] SET idSala = @idSala, idPelicula = @idPelicula, fechaFuncion = @fecha, costoFuncion = @costo WHERE idFuncion = @idFuncion;";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@idFuncion", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@idSala", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@idPelicula", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@fecha", SqlDbType.DateTime));
                command.Parameters.Add(new SqlParameter("@costo", SqlDbType.Int));
                command.Parameters["@idFuncion"].Value = ID;
                command.Parameters["@idSala"].Value = idSala;
                command.Parameters["@idPelicula"].Value = idPelicula;
                command.Parameters["@fecha"].Value = fecha;
                command.Parameters["@costo"].Value = costo;
                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return 0;
                }
            }
        }
        #endregion
        #endregion Final Region Funcion

        #region Salas
        public List<Sala> llenarListaSala()
        {
            List<Sala> misSalas = new List<Sala>();

            string consulta = "SELECT * FROM Salas";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    Sala sala;
                    while (reader.Read())
                    {
                        sala = new Sala(reader.GetInt32(0),reader.GetString(1), reader.GetInt32(2));
                        misSalas.Add(sala);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
            return misSalas;
        }
        #region Alta Sala
        public int altaSalaDB(string ubicacion, int capacidad)
        {
            //Confirmamos que podamos agregar el registro a la base de datos
            int resultadoQuery;
            int idNuevaSala = -1;

            string queryString = "INSERT INTO [dbo].[Salas] ([ubicacionSala],[capacidadSala]) VALUES (@ubicacion,@capacidad);";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@ubicacion", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@capacidad", SqlDbType.Int));

                command.Parameters["@capacidad"].Value = capacidad;
                command.Parameters["@ubicacion"].Value = ubicacion;
               
                try
                {
                    connection.Open();
               
                    resultadoQuery = command.ExecuteNonQuery();

               
                    string ConsultaID = "SELECT MAX([idSala]) FROM [dbo].[Salas]";
                    command = new SqlCommand(ConsultaID, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    idNuevaSala = reader.GetInt32(0);
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return -1;
                }
                return idNuevaSala;
            }
        }
        #endregion
        #region Eliminar Sala
        public int eliminarSalaDB(int ID)
        {
            string connectionString = Properties.Resources.ConnectionStr;
            string consulta = "DELETE FROM [dbo].[Salas] WHERE idSala=@idSala";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(consulta, connection);
                command.Parameters.Add(new SqlParameter("@idSala", SqlDbType.Int));
                command.Parameters["@idSala"].Value = ID;
                try
                {
                    connection.Open();

                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return 0;
                }
            }
        }
        #endregion
        #region Modificar Sala
        public int modificarSalaDB(int id, string ubicacion, int capacidad)
        {
            string connectionString = Properties.Resources.ConnectionStr;
            string queryString = "UPDATE [dbo].[Salas] SET ubicacionSala = @ubicacion, capacidadSala = @capacidad WHERE idSala=@idSala;";
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new SqlParameter("@idSala", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@ubicacion", SqlDbType.NVarChar));
                command.Parameters.Add(new SqlParameter("@capacidad", SqlDbType.Int));
                command.Parameters["@idSala"].Value = id;
                command.Parameters["@ubicacion"].Value = ubicacion;
                command.Parameters["@capacidad"].Value = capacidad;
                try
                {
                    connection.Open();
                    //esta consulta NO espera un resultado para leer, es del tipo NON Query
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    return 0;
                }
            }
        }
        #endregion
        #endregion Final Region Sala

        #region UsuarioFuncion
        //Método para completar la lista que representa la tabla interedia entre Usuarios y Funciones (relacion many to many)
        public List<UsuarioFuncion> inicializarUsuarioFuncion()
        {
            List<UsuarioFuncion> usuarioFuncion = new List<UsuarioFuncion>();
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM  Usuario_Funcion";
                SqlCommand command = new SqlCommand(consulta, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        usuarioFuncion.Add(new UsuarioFuncion(reader.GetInt32(0), reader.GetInt32(1)));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {

                    Debug.WriteLine(ex.Message);

                }

            }
            return usuarioFuncion;
        }
        #endregion
    }
}