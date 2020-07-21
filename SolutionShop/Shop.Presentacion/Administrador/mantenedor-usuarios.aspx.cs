using Shop.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.DTO;
using Shop.Negocio;
using System.Configuration;

namespace Shop.Presentacion.Administrador
{

    public partial class mantenedor_usuarios : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {


            if (Page.IsPostBack == false)
            {

                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }

                CargarDatos();
                Response.AppendHeader("Cache-Control", "no-store");

            }
            else
            {
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }
            }

        }

        private void CargarDatos()
        {
            ddlComuna.DataSource = ComunaNegocio.ObtenerComunasAll();
            ddlComuna.DataTextField = "Nombre";
            ddlComuna.DataValueField = "Id";
            ddlComuna.DataBind();

            ddlTipoCliente.DataSource = TipoUsuarioNegocio.ObtenerTiposAll();
            ddlTipoCliente.DataTextField = "NombreTipoUsuario";
            ddlTipoCliente.DataValueField = "Id";
            ddlTipoCliente.DataBind();
        }

        protected void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClienteNegocio.VerificarPerfil(txtEmail.Text))
                {

                    string skey = ConfigurationManager.AppSettings["stKey"];
                    ClienteDTO cliente = new ClienteDTO();
                    cliente.Nombre = txtNombre.Text;
                    cliente.Appaterno = txtAppaterno.Text;
                    cliente.Apmaterno = txtApmaterno.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.IdComuna = int.Parse(ddlComuna.SelectedValue);
                    cliente.Email = txtEmail.Text;
                    cliente.Telefono = int.Parse(txtTelefono.Text);
                    cliente.TipoUsuario = int.Parse(ddlTipoCliente.SelectedValue);
                    cliente.User = txtEmail.Text;
                    //cliente.Pass = txtContrasena.Text;
                    cliente.Pass = EncriptaNegocio.Encripta3DES(txtContrasena.Text, skey);
                    cliente.Rut = txtRut.Text;
                    if (ClienteNegocio.CrearClienteNegocio(cliente))
                    {
                        lblMensaje.Text = "Usuario registrado exitosamente";
                    }
                    else
                    {
                        lblMensaje.Text = "Error, no se pudo registrar usuario";
                    }
                }
                else
                {
                    lblMensaje.Text = "Cliente ya se encuentra registrado";
                }
            }
            catch (Exception ex)
            {

                lblMensaje.Text = ex.Message; ;
            }
        }
    }
}