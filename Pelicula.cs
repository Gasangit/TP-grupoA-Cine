using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_grupoA_Cine
{
    public class Pelicula
    {

        public int ID { set; get; } = 0;
        public string Nombre { set; get; } = "";
        public string Sinopsis { set; get; } = "";
        public List<Funcion> MisFunciones { set; get; } = new List<Funcion>();
        public int Duracion { set; get; } = 0;
        private static int idPelicula;
        public string Poster;

        public Pelicula() { }

        public Pelicula(string nombre, string sinopsis, int duracion, string poster)
        {
            ID = idPelicula++;
            Nombre = nombre;
            Sinopsis = sinopsis;
            Duracion = duracion;
            Poster = poster;
            
        }

        public string[] ToString()
        {

            return new string[]
            {
                ID.ToString(),
                Nombre.ToString(),
                Sinopsis.ToString(),
                Duracion.ToString()
            };


        }
    }
}
