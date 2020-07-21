using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;
using Shop.Data;


namespace Shop.Negocio
{
    public class GrupoInfoNegocio
    {
        public static List<GrupoInfoDTO> ObtenerGruposInfoAll()
        {
            return GrupoInfoData.ObtenerGrupoInfoAllData();
        }

        public static GrupoInfoDTO ObtenerGrupoInfoXID(int id)
        {
            return GrupoInfoData.ObtenerGrupoInfoAllData().Where(p=>p.Id==id).First();
        }
        
        public static List<GrupoInfoDTO> ObtenerGruposInfoJoinInfo()
        {
            List<GrupoInfoDTO> listaGrupo= GrupoInfoData.ObtenerGrupoInfoAllData();
            List<InformacionDTO> listaInfo = InformacionNegocio.ObtenerInformacionAllNegocio();

            List<GrupoInfoDTO> listaGrupoFinal = (from grupo in listaGrupo
                                                  join info in listaInfo
                                                  on grupo.Id_Info equals info.Id
                                                  select new GrupoInfoDTO
                                                  {
                                                      Id = grupo.Id,
                                                      Nombre = grupo.Nombre,
                                                      Titulo = grupo.Titulo,
                                                      Descripcion = grupo.Descripcion,
                                                      Img = grupo.Img,
                                                      Estado = grupo.Estado,
                                                      Id_Info = grupo.Id_Info,
                                                      nombreTipoInfo = info.Nombre
                                                  }).ToList();

            return listaGrupoFinal;
        }

        public static List<GrupoInfoDTO> ObtenerGruposInfoXInfo(int idInfo)
        {
            //return GrupoInfoData.ObtenerGrupoInfoAllData().Where(p=>p.Id_Info==idInfo).ToList();
            List<GrupoInfoDTO> listaGrupo = GrupoInfoData.ObtenerGrupoInfoAllData();
            List<InformacionDTO> listaInfo = InformacionNegocio.ObtenerInformacionAllNegocio();

            List<GrupoInfoDTO> listaGrupoFinal = (from grupo in listaGrupo
                                                  join info in listaInfo
                                                  on grupo.Id_Info equals info.Id
                                                  where grupo.Id_Info==idInfo
                                                  select new GrupoInfoDTO
                                                  {
                                                      Id = grupo.Id,
                                                      Nombre = grupo.Nombre,
                                                      Titulo = grupo.Titulo,
                                                      Descripcion = grupo.Descripcion,
                                                      Img = grupo.Img,
                                                      Estado = grupo.Estado,
                                                      Id_Info = grupo.Id_Info,
                                                      nombreTipoInfo = info.Nombre
                                                  }).ToList();

            return listaGrupoFinal;
        }

        public static bool CrearGrupoInfo(GrupoInfoDTO grupo)
        {
            return GrupoInfoData.MantenedorGrupoInfo(grupo,1);
        }

        public static bool ActualizarGrupoInfoConImagen(GrupoInfoDTO grupo)
        {
            return GrupoInfoData.MantenedorGrupoInfo(grupo, 2);
        }
        public static bool EliminarGrupoInfo(GrupoInfoDTO grupo)
        {
            return GrupoInfoData.MantenedorGrupoInfo(grupo, 3);
        }

        public static bool ActualizarGrupoInfoSinImagen(GrupoInfoDTO grupo)
        {
            return GrupoInfoData.MantenedorGrupoInfo(grupo, 4);
        }

        public static List<GrupoInfoDTO> ObtenerGrupoInfoFilterInfo(int idInfo)
        {
            return GrupoInfoData.ObtenerGrupoInfoAllData().Where(p=>p.Id_Info==idInfo).ToList();
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
