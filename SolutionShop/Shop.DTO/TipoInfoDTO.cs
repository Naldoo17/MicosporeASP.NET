using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DTO
{
    public class TipoInfoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public TipoInfoDTO()
        {
            Id = 0;
            Nombre = string.Empty;
        }
    }
}
