using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DTO
{
    public class GrupoInfoDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public string Img { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }      
        public int Id_Info { get; set; }

        public int Id_tipo_info { get; set; }
        public string nombreTipoInfo { get; set; }

        public GrupoInfoDTO()
        {
            Id = 0;
            Nombre = string.Empty;
            Titulo = string.Empty;
            Img = string.Empty;
            Descripcion = string.Empty;
            Estado = 0;
            Id_Info = 0;
            Id_tipo_info = 0;
            nombreTipoInfo = string.Empty;
        }
    }
}
