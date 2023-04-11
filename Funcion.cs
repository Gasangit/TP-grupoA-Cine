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
    internal class Funcion
    {
        public int ID { set; get; }
        public Sala MiSala { set; get; }
        public Pelicula MiPelicula  { set; get; }
        public List<Usuario> Clientes { set; get; }
        public DateTime Fecha { set; get; }
        public int CantClientes { set; get; }
        public double Costo { set; get; }
        private static int idFuncion { set; get; }

        public Funcion(Sala MiSala, Pelicula MiPelicula, DateTime Fecha, int CantClientes, double Costo) 
        {
            ID = idFuncion++;
            this.MiSala = MiSala;
            this.MiPelicula = MiPelicula;  
            this.Fecha = Fecha;
            this.CantClientes = CantClientes;
            this.Costo = Costo;

        }
    }

}