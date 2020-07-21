using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DTO
{
    public class ClienteDTO : UsuarioDTO
    {
        private string _rut;

        public string Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _appaterno;

        public string Appaterno
        {
            get { return _appaterno; }
            set { _appaterno = value; }
        }

        private string _apmaterno;

        public string Apmaterno
        {
            get { return _apmaterno; }
            set { _apmaterno = value; }
        }

        private string _direccion;

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public int IdComuna { get; set; }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Telefono { get; set; }

       

        public ClienteDTO()
        {
            
            User = string.Empty;
            Pass = string.Empty;
            TipoUsuario = 0;
            Rut = string.Empty;
            Nombre = string.Empty;
            Appaterno = string.Empty;
            Apmaterno = string.Empty;
            Direccion = string.Empty;
            Email = string.Empty;
            IdComuna = 0;
            Telefono = 0;
            TipoUsuario = 0;
        }

        

    }
}
