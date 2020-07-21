using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;


namespace Shop.Data
{
    public class UsuarioData
    {
        public static Boolean ValidaUserData(string correo, string pass)
        {
            try
            {
                bool valida = false;
                //string test = ConfigurationManager.ConnectionStrings["DB_A5AC51_micosporeTestEntities"].ConnectionString;
                //using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities(test))
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {

                    var lista = db.VALIDA_USER(correo, pass).ToList();
                    int cantidad = 0;
                    cantidad = lista.Count();
                    if (cantidad > 0)
                    {

                        valida = true;
                    }
                    else
                    {
                        valida = false;
                    }
                }
                return valida;
            }
            catch (Exception ex)
            {

                return false;
            }

        }


        public static ClienteDTO ObtenerDetallesUsuarioData(string username, string pass)
        {
            try
            {
                ClienteDTO cliente = new ClienteDTO();

                using (DB_A5AC51_micosporeEntities db= new DB_A5AC51_micosporeEntities()) {

                    var lista = db.SP_SELECT_DETALLE_USUARIO(username,pass).ToList();

                    if (lista!=null && lista.Count() > 0)
                    {
                        cliente.User = lista.First().EMAIL.ToString();
                        cliente.TipoUsuario = (int)lista.First().TIPO_USUARIO;
                        cliente.Rut = lista.First().RUT.ToString();
                        cliente.Nombre = lista.First().NOMBRE.ToString();
                        cliente.Appaterno = lista.First().APPATERNO.ToString();
                        cliente.Apmaterno = lista.First().APMATERNO.ToString();
                        cliente.Direccion = lista.First().DIRECCION.ToString();
                        cliente.IdComuna = (int)lista.First().ID_COMUNA;
                        cliente.Email = lista.First().EMAIL.ToString();
                        cliente.Telefono = (int)lista.First().TELEFONO;
                    }

                }

                    return cliente;
            }
            catch (Exception)
            {

                return null;
            }
        }


        public static UsuarioDTO ObtenerUserData(string correo, string pass)
        {
            try
            {
                UsuarioDTO user = new UsuarioDTO();
                
               
                using (DB_A5AC51_micosporeEntities db = new DB_A5AC51_micosporeEntities())
                {

                    var lista = db.SP_SELECT_DETALLE_USUARIO(correo, pass).ToList();
                    UsuarioDTO usuario = new UsuarioDTO();

                    
                    


                }
                return user;
            }
            catch (Exception ex)
            {

                return new UsuarioDTO();
            }

        }

    }


}
