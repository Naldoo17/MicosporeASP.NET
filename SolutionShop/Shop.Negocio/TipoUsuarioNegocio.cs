using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Data;
using Shop.DTO;

namespace Shop.Negocio
{
    public class TipoUsuarioNegocio
    {
        public static List<TipoUsuarioDTO> ObtenerTiposAll()
        {
            return TipoUsuarioData.ObtenerTiposUsuariosAllData();
        }
    }
}
