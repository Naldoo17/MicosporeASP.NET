using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Data;
using Shop.DTO;

namespace Shop.Negocio
{
    public class InformacionNegocio
    {
        public static List<InformacionDTO> ObtenerInformacionAllNegocio()
        {
            return InformacionData.ObternerInformacionAllData();
        }

        public static List<InformacionDTO> ObtenerInformacionAllJoinTipoInfoNegocio()
        {
            var lista= InformacionData.ObternerInformacionAllData();
            List<TipoInfoDTO> listaTipo = TipoInfoNegocio.ObtenerTiposInfo();
            List<InformacionDTO> listaInfo = (from t in listaTipo
                                              join i in lista
                                              on t.Id equals i.IdTipo
                                              select new InformacionDTO()
                                              {
                                                  Id = i.Id,
                                                  Nombre = i.Nombre,
                                                  Titulo = i.Titulo,
                                                  Descripcion = i.Descripcion,
                                                  Img = i.Img,
                                                  Estado = i.Estado,
                                                  IdTipo = i.IdTipo,
                                                  NombreTipo = t.Nombre
                                              }).ToList();

            return listaInfo;
        }

        public static bool CrearInformacionNegocio(InformacionDTO info)
        {
            return InformacionData.MatenedorInformacionData(info, 1);
        }

        public static bool EditarInformacionConImagenNegocio(InformacionDTO info)
        {
            return InformacionData.MatenedorInformacionData(info, 2);
        }
        public static bool EliminarInformacionNegocio(InformacionDTO info)
        {
            return InformacionData.MatenedorInformacionData(info, 3);
        }

        public static bool EditarInformacionSinmImagenNegocio(InformacionDTO info)
        {
            return InformacionData.MatenedorInformacionData(info, 4);
        }


    }
}
