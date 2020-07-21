using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;
using Shop.Data;

namespace Shop.Negocio
{
    public class TipoInfoNegocio
    {
        public static List<TipoInfoDTO> ObtenerTiposInfo()
        {
            return TipoInfoData.ObtenerTipoInfoAllData();
        }




        public static TipoInfoDTO ObtenerTipoInfoFiltroID(int tipo)
        {

            TipoInfoDTO tipoInfo = new TipoInfoDTO();
            using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
            {
                TIPO_INFO tipoData = db.TIPO_INFO.Where(p => p.ID == tipo).First();
                tipoInfo.Id = tipoData.ID;
                tipoInfo.Nombre = tipoData.NOMBRE;
            }
            return tipoInfo;

        }

        public static bool CrearTipoInfo(TipoInfoDTO tipo)
        {
            return TipoInfoData.MantenedorTipoInfo(tipo,1);
        }

        public static bool ActualizarTipoInfo(TipoInfoDTO tipo)
        {
            return TipoInfoData.MantenedorTipoInfo(tipo, 2);
        }

        public static bool EliminarTipoInfo(TipoInfoDTO tipo)
        {
            return TipoInfoData.MantenedorTipoInfo(tipo, 3);
        }
    }
}
