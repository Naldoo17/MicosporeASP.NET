using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DTO
{
    public class InformacionDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Img { get; set; }
        public int IdTipo { get; set; }
        public int Estado { get; set; }

        public string NombreTipo { get; set; }
        public InformacionDTO()
        {
            Id = 0;
            Nombre = "";
            Titulo = "";
            Descripcion = "";
            Img = "";
            IdTipo = 0;
            Estado = 0;
            NombreTipo = "";
        }





    }
}
