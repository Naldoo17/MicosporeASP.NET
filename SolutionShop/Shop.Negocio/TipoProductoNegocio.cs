using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;
using Shop.Data;
namespace Shop.Negocio
{
    public class TipoProductoNegocio
    {
        public static List<TipoProductoDTO> ObtenerTipoProductosActivosAll()
        {
            return TipoProductoData.ObtenerTipoProductosActivosAllData();
        }

        public static TipoProductoDTO ObtenerTipoProductoFiltroID(int idTipoProd)
        {
            return TipoProductoData.ObtenerTipoProductosFiltroID(idTipoProd);
        }


        public static List<TipoProductoDTO> ObtenerTipoProductosAll()
        {
            return TipoProductoData.ObtenerTipoProductosAllData();
        }
        public static bool CrearTipoProducto(TipoProductoDTO tipo)
        {
            return TipoProductoData.MantenedorTipoProductoData(tipo, 1);
        }

        public static bool ActualizaTipoProductoConImagen(TipoProductoDTO tipo)
        {
            return TipoProductoData.MantenedorTipoProductoData(tipo, 2);
        }

        public static bool ActualizaTipoProductoSinImagen(TipoProductoDTO tipo)
        {
            return TipoProductoData.MantenedorTipoProductoData(tipo, 4);
        }

        public static bool EliminaTipoProducto(TipoProductoDTO tipo)
        {
            return TipoProductoData.MantenedorTipoProductoData(tipo, 3);
        }

       
        public static string TipoToString(int tipo)
        {
            string salida = "";

            if (tipo == 1)
            {
                salida = "Activo";
            }
            else
            {
                salida = "Inactivo";
            }

            return salida;

        }

    }
}
