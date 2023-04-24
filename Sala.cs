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
    public class Sala
    {
        public int ID { get; set; }
        public string Ubicacion { get; set; }
        public int Capacidad { get; set; }
        public List<Funcion> MisFunciones { get; set; }
        private static int idSala { get; set; }

        public Sala(string Ubicacion, int Capacidad)
        {
            ID = ++idSala;
            this.Ubicacion = Ubicacion;
            this.Capacidad = Capacidad;            
        }        
    }    
}