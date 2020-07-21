using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;
namespace Shop.Data
{
    public class GrupoInfoData
    {

        public static List<GrupoInfoDTO> ObtenerGrupoInfoAllData()
        {
            try
            {

                List<GrupoInfoDTO> listaGrupo = new List<GrupoInfoDTO>();
                //using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())

                {

                    foreach (var aux in db.GRUPO_INFORMACION)
                    {
                        //if (aux.ESTADO == 1)
                        //{
                            GrupoInfoDTO grupo = new GrupoInfoDTO();
                            grupo.Id = aux.ID;
                            grupo.Nombre = aux.NOMBRE;
                            grupo.Titulo = aux.TITULO;
                            grupo.Img = aux.IMG;
                            grupo.Descripcion = aux.DESCRIPCION;
                            grupo.Estado = (int)aux.ESTADO;
                            grupo.Id_Info = (int)aux.ID_INFO;
                            grupo.Id_tipo_info = (int)aux.ID_TIPO_INFO;
                            listaGrupo.Add(grupo);
                        //}

                    }
                }

                return listaGrupo;
            }
            catch (Exception ex)
            {


                return null;
            }
        }



        public static bool MantenedorGrupoInfo(GrupoInfoDTO grupo, int accion)
        {
            try
            {
                bool valida = false;
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {
                    db.SP_MANTENEDOR_GRUPO_INFORMACION(grupo.Id, grupo.Nombre, grupo.Titulo, grupo.Descripcion, "img/" + grupo.Img, grupo.Estado, grupo.Id_Info, grupo.Id_tipo_info, accion);
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
