using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_grupoA_Cine
{
    public class UsuarioFuncion
    {
        //Esta clase se crea ya que la relacion Usaurio-Funcion es MANY to MANY y se utiliza tabla intermedia
        
        public Usuario IdObjetoUsuario { get; set; } = new Usuario();
        public Funcion IdObjetoFuncion { get; set; } = new Funcion();

        //public int idUsuario { get; set; }
        //public int idFuncion { get; set; }
        public int cantidadCompra { get; set; }

        public UsuarioFuncion(Usuario IdObjetoUsuario, Funcion IdObjetoFuncion, int cantidadCompra)
        { 
            this.IdObjetoUsuario = IdObjetoUsuario;
            this.IdObjetoFuncion = IdObjetoFuncion;
            this.cantidadCompra = cantidadCompra;
            this.idUsuario = IdObjetoUsuario.ID;
            this.idFuncion = IdObjetoFuncion.ID;
        }

        public string[] ToString()
        {
            return new string[]
            {
                IdObjetoUsuario.ID.ToString(), IdObjetoFuncion.ID.ToString(), cantidadCompra.ToString() 
            };        
        }
    }
}
