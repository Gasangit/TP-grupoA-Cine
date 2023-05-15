﻿using System;
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
    public class Funcion
    {
        public int ID { set; get; } = 0;
        public Sala MiSala { set; get; } = new Sala();
        public Pelicula MiPelicula { set; get; } = new Pelicula();
        public List<Usuario> Clientes { set; get; } = new List<Usuario>();
        public DateTime Fecha { set; get; } = new DateTime();
        //public int CantClientes { set; get; } = 0;
        public double Costo { set; get; } = 0.0;
        //private static int idFuncion { set; get; }

        public Funcion() { }


        public Funcion(DateTime Fecha, double Costo)
        {      
            this.Fecha = Fecha;
            this.Costo = Costo;
        }

       public Funcion(int ID, Sala MiSala, Pelicula MiPelicula, DateTime Fecha, double Costo) 
        {
            this.ID = ID; 
            this.MiSala = MiSala;
            this.MiPelicula = MiPelicula;  
            this.Fecha = Fecha;            
            this.Costo = Costo;
        }


        public string[] ToString()
        {

            return new string[]
            {
                ID.ToString(),MiSala.Ubicacion.ToString(),MiSala.ID.ToString(),MiPelicula.Nombre.ToString(),MiPelicula.ID.ToString(), Fecha.ToString(), Costo.ToString() //CantClientes.ToString() // Muestra cantidad de clientes que ya compraron la funcion
            };
        }

        public string[] ToStringFunciones()
        {

            return new string[]
            {
                ID.ToString(),Fecha.ToString(),MiSala.Ubicacion.ToString(),MiPelicula.Nombre.ToString(),"", Costo.ToString() //CantClientes.ToString() // Muestra cantidad de clientes que ya compraron la funcion
            };
        }

    }

}