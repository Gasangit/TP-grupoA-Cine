using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_grupoA_Cine
{
    internal class Pelicula
    {

       public int ID { set; get; }
       public string Nombre { set; get; }
       public string Sinopsis { set; get; }
       public string Poster { set; get; }
       public List<Funcion> MisFunciones { set; get; } = new List<Funcion>();
       public int Duracion { set; get; }
       private static int idPelicula { set; get; }


        public Pelicula(string nombre, string sinopsis, int duracion) 
        {
            ID = ++idPelicula;
            Nombre = nombre;
            Sinopsis = sinopsis;
            Duracion = duracion;
        }

        public Pelicula(string nombre, string sinopsis, int duracion, string poster)
        {
            this.ID = idPelicula++;
            Nombre = nombre;
            Sinopsis = sinopsis;
            Duracion = duracion;
            Poster = poster;
        }
    }
}
