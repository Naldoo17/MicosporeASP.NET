using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DTO
{
    public class UsuarioDTO
    {
        private string _user;

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        private string _pass;

        public string Pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        private int _tipoUsuario;

        public int TipoUsuario
        {
            get { return _tipoUsuario; }
            set { _tipoUsuario = value; }
        }


        public UsuarioDTO()
        {
            User = string.Empty;
            Pass = string.Empty;
            TipoUsuario = 0;
        }
    }
}
