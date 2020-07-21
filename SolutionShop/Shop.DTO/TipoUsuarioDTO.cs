using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DTO
{
    public class TipoUsuarioDTO
    {
        public int Id { get; set; }
        public string NombreTipoUsuario { get; set; }


        public TipoUsuarioDTO()
        {
            Id = 0;
            NombreTipoUsuario = "";
        }
    }
}
