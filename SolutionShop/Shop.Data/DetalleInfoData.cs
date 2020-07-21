using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;
namespace Shop.Data
{
    public class DetalleInfoData
    {
        public static List<DetalleInfoDTO> ObtenerDetalleInfoAllData()
        {
			try
			{
				List<DetalleInfoDTO> listaDetalle = new List<DetalleInfoDTO>();

				using (DB_A5AC51_micosporeEntities db= new DB_A5AC51_micosporeEntities())
				{
					foreach (var aux in db.DETALLE_INFORMACION)
					{
						DetalleInfoDTO detalle = new DetalleInfoDTO();
						detalle.Id = aux.ID;
						detalle.Nombre = aux.NOMBRE;
						detalle.Titulo = aux.TITULO;
						detalle.Img = aux.IMG;
						detalle.Descripcion = aux.DESCRIPCION;
						detalle.Estado = (int)aux.ESTADO;
						detalle.Id_Grupo = (int)aux.ID_GRUPO;
						listaDetalle.Add(detalle);
					}
				}
				return listaDetalle;
			}
			catch (Exception ex)
			{

				return null;
			}
        }
    }
}
