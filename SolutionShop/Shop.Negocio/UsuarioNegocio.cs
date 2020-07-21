using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;
using Shop.Data;

namespace Shop.Negocio
{
    public class UsuarioNegocio
    {
        public static bool ValidaUserLogin(string username,string pass,string skey)
        {

            //return UsuarioData.ValidaUserData(username, pass);
            return UsuarioData.ValidaUserData(username, EncriptaNegocio.Encripta3DES(pass,skey));
        }

        public static ClienteDTO ObtenerDetalleClienteNegocio(string username, string pass, string skey)
        {
            return UsuarioData.ObtenerDetallesUsuarioData(username, EncriptaNegocio.Encripta3DES(pass, skey));
        }

        
    }
}
