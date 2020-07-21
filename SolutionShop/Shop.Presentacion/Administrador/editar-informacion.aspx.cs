using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.DTO;
using Shop.Negocio;



namespace Shop.Presentacion.Administrador
{
    public partial class editar_informacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           

            if (Page.IsPostBack == false)
            {
             
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }
                int idInfo = int.Parse(Request.QueryString["idInfo"]);
                cargarDatos(idInfo);
            }
            else
            {
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }
            }
        }

        private void cargarDatos(int idInfo)
        {

            InformacionDTO info = InformacionNegocio.ObtenerInformacionAllNegocio().Where(p => p.Id == idInfo).First();

            if (info == null)
            {
                lblmensaje.Text = "Informacion no encotrada";
                return;
            }
            ListItem activo = new ListItem("Activo", "1");
            ListItem inActivo = new ListItem("Inactivo", "0");
            ddlEstado.Items.Add(activo);
            ddlEstado.Items.Add(inActivo);

            ddlTipoInfo.DataSource = TipoInfoNegocio.ObtenerTiposInfo();
            ddlTipoInfo.DataValueField = "Id";
            ddlTipoInfo.DataTextField = "Nombre";
            ddlTipoInfo.DataBind();

            txtNombre.Text = info.Nombre;
            txtTitulo.Text = info.Titulo;
            txtDescripcion.Text = info.Descripcion;
            hdImagen.Value = info.Img;
            ddlEstado.SelectedValue = info.Estado.ToString();
            ddlTipoInfo.SelectedValue = info.IdTipo.ToString();

        }

        protected void btnGuardarInfo_Click(object sender, EventArgs e)
        {
            try
            {
                int idInfo = int.Parse(Request.QueryString["idInfo"]);
                InformacionDTO info = new InformacionDTO();
                info.Id = idInfo;
                info.Nombre = txtNombre.Text;
                info.Titulo = txtTitulo.Text;
                info.Descripcion = txtDescripcion.Text;
                info.Estado = int.Parse(ddlEstado.SelectedValue);
                info.IdTipo = int.Parse(ddlTipoInfo.SelectedValue);
                if (FileUploadImagen.HasFile)
                {
                    string filename = Path.GetFileName(FileUploadImagen.FileName);
                    FileUploadImagen.SaveAs(Server.MapPath("~/img/") + filename);
                    info.Img = filename;
                    if (InformacionNegocio.EditarInformacionConImagenNegocio(info))
                    {
                        lblmensaje.Text = "Actualizado correctamente con carga de imagen";
                        limpiar();
                    }
                    else
                    {
                        lblmensaje.Text = "Error al actualizar con carga de imagen";
                    }
                }
                else
                {
                    if (InformacionNegocio.EditarInformacionSinmImagenNegocio(info))
                    {
                        lblmensaje.Text = "Actualizado correctamente";
                        limpiar();
                    }
                    else
                    {
                        lblmensaje.Text = "Error al actualizar";
                    }
                }


            }
            catch (Exception ex)
            {

                lblmensaje.Text = ex.Message;
            }
        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtTitulo.Text = "";
        }
    }
}


