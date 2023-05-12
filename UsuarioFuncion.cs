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
        public int idUsuario { get; set; }

        public int idFuncion { get; set; }

        public int cantidadCompra { get; set; }

        public UsuarioFuncion(int idUsuario, int idFuncion)
        { 
            this.idUsuario = idUsuario;
            this.idFuncion = idFuncion;
        }
    }
}
