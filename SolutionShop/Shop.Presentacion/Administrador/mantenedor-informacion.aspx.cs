using Shop.DTO;
using Shop.Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Presentacion.Administrador
{
    public partial class mantenedor_informacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (Page.IsPostBack == false)
            {
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }
                CargaDatos();
            }
            else
            {
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }
            }

        }

        private void CargaDatos()
        {
            ListItem activo = new ListItem("Activo", "1");
            ListItem inActivo = new ListItem("Inactivo", "0");
            ddlEstado.Items.Add(activo);
            ddlEstado.Items.Add(inActivo);

            ddlTipoInfo.DataSource = TipoInfoNegocio.ObtenerTiposInfo();
            ddlTipoInfo.DataValueField = "Id";
            ddlTipoInfo.DataTextField = "Nombre";
            ddlTipoInfo.DataBind();


            //gvInformacion.DataSource = InformacionNegocio.ObtenerInformacionAllNegocio();
            //gvInformacion.DataBind();

        }


        //public static bool guardarInfo()

        protected void btnGuardarInfo_Click(object sender, EventArgs e)
        {
            try
            {

                if (FileUploadImagen.HasFile)
                {
                    string nombreArchivo= Path.GetFileName(FileUploadImagen.FileName);
                    FileUploadImagen.SaveAs(Server.MapPath("~/img/") + nombreArchivo);
                   
                    InformacionDTO info = new InformacionDTO();
                    info.Nombre = txtNombre.Text;
                    info.Titulo = txtTitulo.Text;
                    info.Img = nombreArchivo;
                    info.Descripcion = txtDescripcion.Text;
                    info.Estado = int.Parse(ddlEstado.SelectedValue);
                    info.IdTipo = int.Parse(ddlTipoInfo.SelectedValue);
                    if (InformacionNegocio.CrearInformacionNegocio(info))
                    {
                        lblmensaje.Text = "Información creada exitosamente";
                        limpiar();
                    }
                    else
                    {
                        lblmensaje.Text = "Información no se pudo crear";
                    }


                }
                else
                {
                    lblmensaje.Text = "Debe cargar imagen";
                }

            }
            catch (Exception ex)
            {

                lblmensaje.Text = ex.Message;
            }
        }

        private void limpiar()
        {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            txtTitulo.Text = "";
        }
        
    }
}