using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.Negocio;
using Shop.DTO;
namespace Shop.Presentacion
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoginIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string username = "";
                string password = "";
                bool valida = false;

                username = txtusername.Text;
                password = txtpass.Text;

                //valida = UsuarioNegocio.ValidaUserLogin(username,password,);
                //if (valida==true)
                //{
                   
                //    ClienteDTO cli = UsuarioNegocio.ObtenerDetalleClienteNegocio(username,password);
                //    Redireccion(cli.TipoUsuario);
                //    //lblMensaje.Text = cli.Nombre + " " + cli.Appaterno;
                //}
                //else
                //{
                //    lblMensaje.Text = "login NO valido";
                //}
                
            }
            catch (Exception ex)
            {

                lblMensaje.Text = ex.Message;
            }
        }


        public void Redireccion(int idTipoUsuario)
        {
            switch (idTipoUsuario)
            {
                case 1:
                    Response.Redirect("/Administrador/index.aspx",false);
                    break;
                case 2:
                    break;
                default:
                    break;
            }

        }
    }
}