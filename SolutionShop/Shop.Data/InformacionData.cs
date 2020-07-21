using Shop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class InformacionData
    {
        public static List<InformacionDTO> ObternerInformacionAllData()
        {
            try
            {
                List<InformacionDTO> listaInfo = new List<InformacionDTO>();
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {
                    foreach (var aux in db.INFORMACION)
                    {
                        //if (aux.ESTADO == 1)
                        //{
                            InformacionDTO info = new InformacionDTO();
                            info.Id = aux.ID;
                            info.Nombre = aux.NOMBRE;
                            info.Titulo = aux.TITULO;
                            info.Img = aux.IMG;
                            info.Descripcion = aux.DESCRIPCION;
                            info.Estado = aux.ESTADO;
                            info.IdTipo = aux.ID_TIPO_INFO;
                            listaInfo.Add(info);
                        
                    }

                }
                return listaInfo;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static InformacionDTO ObtenerInformacionFiltroID(int idinfo)
        {
            try
            {
                InformacionDTO info = new InformacionDTO();
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {

                    foreach (var aux in db.INFORMACION)
                    {
                        if (aux.ID == idinfo)
                        {
                            info.Id = (int)aux.ID;
                            info.Nombre = aux.NOMBRE;
                            info.Titulo = aux.TITULO;
                            info.Img = aux.IMG;
                            info.Descripcion = aux.DESCRIPCION;
                            info.Estado = aux.ESTADO;
                            info.IdTipo = (int)aux.ID_TIPO_INFO;
                            break;
                        }

                    }
                }

                return info;

            }
            catch (Exception ex)
            {

                return null;
            }
        }



        public static bool MatenedorInformacionData(InformacionDTO info, int accion)
        {
            try
            {
                bool valida = false;
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {
                    db.SP_MANTENEDOR_INFORMACION(info.Id, info.Nombre, info.Titulo, info.Descripcion, "img/" + info.Img, info.Estado, info.IdTipo, accion);
                    valida = true;
                    db.SaveChanges();
                }

                return valida;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
