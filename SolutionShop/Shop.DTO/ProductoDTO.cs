using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DTO
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public int TipoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
        public string Img { get; set; }

        public int Estado { get; set; }

        public string PrecioFormato { get; set; }
        public string NombreTipoProd { get; set; }

        public string nombreEstado { get; set; }
        public string descripcionCorta { get; set; }

        public ProductoDTO()
        {
            IdProducto = 0;
            TipoProducto = 0;
            NombreProducto = "";
            Descripcion = "";
            Stock = 0;
            Precio = 0;
            Img = "";
            PrecioFormato = formatoPrecio(Precio);
            Estado = 0;
            NombreTipoProd = "";
            nombreEstado = "";
            descripcionCorta = "";
        }

        public string formatoPrecio(double precio)
        {
            CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
            return precio.ToString("00,0", elGR); ;
        }

        public static string RetonaEstadoActivo(int estado)
        {
            string retorno = "";
            switch (estado)
            {
                case 0:
                    retorno = "Inactivo";
                    break;
                case 1:
                    retorno = "Inactivo";
                    break;
            }
            return retorno;

        }



    }
}
