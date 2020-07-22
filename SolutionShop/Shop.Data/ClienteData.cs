using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            bool valida = false;
            try
            {
                //using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                //{
                //    db.SP_MANTENEDOR_CLIENTE_ADMINISTRADOR(cliente.Rut, cliente.Nombre, cliente.Appaterno, cliente.Apmaterno, cliente.Direccion, cliente.Telefono, cliente.Email,  cliente.IdComuna, cliente.Pass, cliente.TipoUsuario, accion);
                //    db.SaveChanges();
                //}

                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db_micospore"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_MANTENEDOR_CLIENTE_ADMINISTRADOR",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@RUT", SqlDbType.VarChar).Value = cliente.Rut;
                    cmd.Parameters.Add("@NOMBRE",SqlDbType.VarChar).Value=cliente.Nombre;
                    cmd.Parameters.Add("@APEPATERNO", SqlDbType.VarChar).Value = cliente.Appaterno;
                    cmd.Parameters.Add("@APEMATERNO", SqlDbType.VarChar).Value = cliente.Apmaterno;
                    cmd.Parameters.Add("@DIRECCION", SqlDbType.VarChar).Value = cliente.Direccion;
                    cmd.Parameters.Add("@TELEFONO", SqlDbType.Int).Value = cliente.Telefono;
                }

                return valida;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

    }
}
