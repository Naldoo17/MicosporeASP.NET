using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;
using Shop.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Globalization;

namespace Shop.Negocio
{
    public class ProductoNegocio
    {
        public static bool CrearProductoNegocio(ProductoDTO producto)
        {
            return ProductoData.CrearProductoData(producto);
        }

        public static bool EliminarProducto(ProductoDTO producto)
        {
            return ProductoData.EliminarProducto(producto);
        }

        public static List<ProductoDTO> ObtenerProductosAllNegocio()
        {
            return ProductoData.ObtenerProductosAllData();
        }

        public static ProductoDTO ObtenerProductoFiltroID(int id)
        {
            return ProductoData.ObtenerProductoFiltroID(id);
        }

        public static bool ActualizarProducto(ProductoDTO prod, int accion)
        {
            return ProductoData.ActualizarProducto(prod, accion);
        }


        public static List<ProductoDTO> ObtenerProductosAllFiltroTipoProd(int tipoProducto)
        {
            return ProductoData.ObtenerProductosAllFiltroTipoProdData(tipoProducto);
        }

        public static string FormateoPrecio(int precio)
        {
            return precio.ToString("N0", CultureInfo.CurrentCulture);
        }

        public static List<ProductoDTO> ObtenerListaProductosJoinTipo()
        {
            return ProductoData.ObtenerListaProductosJoinTipoData();

        }


    }
}
