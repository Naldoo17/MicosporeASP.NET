using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DTO
{
    public class DetalleInfoDTO
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public string Img { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public int Id_Grupo { get; set; }

        public DetalleInfoDTO()
        {
            Id = 0;
            Nombre = string.Empty;
            Titulo = string.Empty;
            Img = string.Empty;
            Descripcion = string.Empty;
            Estado = 0;
            Id_Grupo = 0;
        }
    }
}
