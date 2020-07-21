using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DTO
{
    public class TipoProductoDTO
    {

        public int idTipoProducto { get; set; }
        public string nombreProducto { get; set; }

        public string descripcion { get; set; }
        public string img { get; set; }
        public int activo { get; set; }

        public string nombreEstado { get; set; }

        public TipoProductoDTO()
        {
            idTipoProducto = 0;
            nombreProducto = "";
            descripcion = "";
            img = "";
            activo = 0;
            
            
        }


    }
}
