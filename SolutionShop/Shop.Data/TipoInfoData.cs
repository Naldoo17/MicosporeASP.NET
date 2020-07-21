using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;

namespace Shop.Data
{
    public class TipoInfoData
    {
        public static List<TipoInfoDTO> ObtenerTipoInfoAllData()
        {
            try
            {
                List<TipoInfoDTO> listaTipos = new List<TipoInfoDTO>();

                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {
                    foreach (var aux in db.TIPO_INFO)
                    {
                        TipoInfoDTO tipo = new TipoInfoDTO();
                        tipo.Id = aux.ID;
                        tipo.Nombre = aux.NOMBRE;
                        listaTipos.Add(tipo);
                    }
                }

                return listaTipos;
            }
            catch (Exception)
            {

                return null;
            }
        }



        public static bool MantenedorTipoInfo(TipoInfoDTO tipo, int accion)
        {
            try
            {

                using (DB_A5AC51_micosporeEntities db= new DB_A5AC51_micosporeEntities())
                {
                    db.SP_MANTENEDOR_TIPO_INFO(tipo.Id,tipo.Nombre,accion);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
