using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.Negocio;
using Shop.DTO;
using System.IO;

namespace Shop.Presentacion.Administrador
{
    public partial class mantenedor_grupo : System.Web.UI.Page
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

            ddlTipoModuloInfo.DataSource = InformacionNegocio.ObtenerInformacionAllNegocio().OrderBy(p => p.Nombre).Where(p => p.Estado == 1).ToList();
            ddlTipoModuloInfo.DataValueField = "Id";
            ddlTipoModuloInfo.DataTextField = "Nombre";
            ddlTipoModuloInfo.DataBind();



            //gvInformacion.DataSource = InformacionNegocio.ObtenerInformacionAllNegocio();
            //gvInformacion.DataBind();

        }

        protected void btnGuardarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUploadImagen.HasFile)
                {
                    string nombreArchivo = Path.GetFileName(FileUploadImagen.FileName);
                    FileUploadImagen.SaveAs(Server.MapPath("~/img/") + nombreArchivo);
                    GrupoInfoDTO grupo = new GrupoInfoDTO();
                    grupo.Nombre = txtNombre.Text;
                    grupo.Titulo = txtTitulo.Text;
                    grupo.Id_Info = int.Parse(ddlTipoModuloInfo.SelectedValue);
                    grupo.Descripcion = txtDescripcion.Text;
                    grupo.Estado = int.Parse(ddlEstado.SelectedValue);
                    grupo.Img = nombreArchivo;
                    if (GrupoInfoNegocio.CrearGrupoInfo(grupo))
                    {
                        lblmensaje.Text = "Grupo creado exitosamente";
                    }
                    else
                    {
                        lblmensaje.Text = "Error, no se pudo crear grupo";
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
    }
}