using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.DTO;
using Shop.Negocio;

namespace Shop.Presentacion
{
    public partial class login_micospore : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {         

            if (Page.IsPostBack == false)
            {


                if (Session["user"] != null && Session["rutUser"] != null && Session["idTipoUser"] != null)
                {
                    string user = (string)Session["user"];
                    string rutUser = (string)Session["rutUser"];
                    string idTipoUser = Session["idTipoUser"].ToString();
                    Redireccionar(user, rutUser, idTipoUser);
                }
                else
                {

                }
            }
        }

        //protected void btnLogin_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string username = "";
        //        string password = "";
        //        bool valida = false;

        //        username = txtCorreo.Text;
        //        password = txtPass.Text;
        //        string skey = ConfigurationManager.AppSettings["stKey"];
        //        valida = UsuarioNegocio.ValidaUserLogin(username, password, skey);
        //        if (valida == true)
        //        {

        //            ClienteDTO cli = UsuarioNegocio.ObtenerDetalleClienteNegocio(username, password, skey);
        //            RedireccionCliente(cli);
        //            //lblMensaje.Text = cli.Nombre + " " + cli.Appaterno;
        //        }
        //        else
        //        {
        //            lblMensaje.Text = "Error de email o contraseña";
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        lblMensaje.Text = ex.Message;
        //    }
        //}

        private void RedireccionCliente(ClienteDTO cliente)
        {
            Session["user"] = cliente.Nombre + " " + cliente.Appaterno;
            Session["rutUser"] = cliente.Rut;
            Session["correo"] = cliente.Email;
            Session["idTipoUser"] = cliente.TipoUsuario;
            switch (cliente.TipoUsuario)
            {
                case 1:
                    Response.Redirect("~/Administrador/index.aspx", false);
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        public void Redireccionar(string user, string rutUser, string idTipoUser)
        {
            switch (int.Parse(idTipoUser))
            {
                case 1:
                    Response.Redirect("~/Administrador/index.aspx", false);
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = "";
                string password = "";
                bool valida = false;

                username = txtCorreo.Text;
                password = txtPass.Text;
                string skey = ConfigurationManager.AppSettings["stKey"];
                valida = UsuarioNegocio.ValidaUserLogin(username, password, skey);
                if (valida == true)
                {

                    ClienteDTO cli = UsuarioNegocio.ObtenerDetalleClienteNegocio(username, password, skey);
                    RedireccionCliente(cli);
                    //lblMensaje.Text = cli.Nombre + " " + cli.Appaterno;
                }
                else
                {
                    lblMensaje.Text = "Error de email o contraseña";
                }

            }
            catch (Exception ex)
            {

                lblMensaje.Text = ex.Message;
            }
        }
    }
}