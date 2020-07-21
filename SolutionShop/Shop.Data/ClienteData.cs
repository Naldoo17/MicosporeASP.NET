using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;

namespace Shop.Data
{
    public class ClienteData
    {
        
        public static bool MantenedorClienteData(ClienteDTO cliente,int accion)
        {
            try
            {
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {
                    //db.SP_MANTENEDOR_CLIENTE_ADMINISTRADOR(cliente.Rut,cliente.Nombre,cliente.Appaterno,cliente.Apmaterno,cliente.Direccion,cliente.Telefono,cliente.Email,cliente.IdComuna,cliente.Pass,cliente.TipoUsuario,1);
                    db.SP_MANTENEDOR_CLIENTE_ADMINISTRADOR(cliente.Rut, cliente.Nombre, cliente.Appaterno, cliente.Apmaterno, cliente.Direccion, cliente.Telefono, cliente.Email,  cliente.IdComuna, cliente.Pass, cliente.TipoUsuario, accion);
                    db.SaveChanges();
                }


                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

    }
}
