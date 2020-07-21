using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;
using Shop.Data;
namespace Shop.Negocio
{
    public class ComunaNegocio
    {
        public  static List<ComunaDTO> ObtenerComunasAll()
        {
            return ComunaData.ObtenerComunasAll();
        }

        public static bool crearComunaNegocio(ComunaDTO comuna)
        {
            return ComunaData.mantenedorComuna(comuna,1);
        }

        public static bool actualizarComunaNegocio(ComunaDTO comuna)
        {
            return ComunaData.mantenedorComuna(comuna, 2);
        }

        public static bool eliminarComunaNegocio(ComunaDTO comuna)
        {
            return ComunaData.mantenedorComuna(comuna, 3);
        }
    }
}
