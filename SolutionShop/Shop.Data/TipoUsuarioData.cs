using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;

namespace Shop.Data
{
    public class TipoUsuarioData
    {
        public static List<TipoUsuarioDTO> ObtenerTiposUsuariosAllData()
        {
			try
			{
				List<TipoUsuarioDTO> listaTipos = new List<TipoUsuarioDTO>();

				using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
				{
					foreach (var aux in db.TIPO_USUARIO)
					{
						TipoUsuarioDTO tipo = new TipoUsuarioDTO();
						tipo.Id = aux.ID_TIPO_USUARIO;
						tipo.NombreTipoUsuario = aux.DESCRIPCION;
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
    }
}
