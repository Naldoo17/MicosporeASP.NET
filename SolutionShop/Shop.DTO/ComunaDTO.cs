using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DTO
{
    public class ComunaDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ComunaDTO()
        {
            Id = 0;
            Nombre = string.Empty;
        }
    }
}
