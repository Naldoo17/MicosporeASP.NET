using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Data;
using Shop.DTO;


namespace Shop.Negocio
{
    public class ClienteNegocio
    {
        public static bool CrearClienteNegocio(ClienteDTO cliente)
        {
            return ClienteData.MantenedorClienteData(cliente, 1);
        }


        public static bool VerificarPerfil(string email)
        {
            int contador = 0;
            bool valida = false;

            using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
            {
                contador = db.CLIENTE.Where(p => p.EMAIL == email).Count();
                if (contador > 0)
                {
                    valida = false;
                }
                else
                {
                    valida = true;
                }
            }
            return valida;

        }
    }
}
