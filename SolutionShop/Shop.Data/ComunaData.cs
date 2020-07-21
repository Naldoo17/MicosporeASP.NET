using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;

namespace Shop.Data
{
    public class ComunaData
    {
        public static List<ComunaDTO> ObtenerComunasAll()
        {
			try
			{
				List<ComunaDTO> comunas = new List<ComunaDTO>();
				
				using (DB_A5AC51_micosporeEntities db= new DB_A5AC51_micosporeEntities())
				{
					foreach (var aux in db.COMUNA)
					{
						ComunaDTO comuna = new ComunaDTO();
						comuna.Id = aux.ID_COMUNA;
						comuna.Nombre = aux.NOMBRE;
						comunas.Add(comuna);
					}
				}
				return comunas;

			}
			catch (Exception ex)
			{

				return null;
			}
        }


		public static bool mantenedorComuna(ComunaDTO comuna, int accion)
		{
			try
			{

				bool valida = false;
				using (DB_A5AC51_micosporeEntities db= new DB_A5AC51_micosporeEntities())
				{
					db.SP_MANTENEDOR_COMUNA(comuna.Id.ToString(),comuna.Nombre,accion);
					db.SaveChanges();
					valida = true;
				}
				

				return valida;
			}
			catch (Exception ex)
			{

				return false;
			}
		}
    }
}
