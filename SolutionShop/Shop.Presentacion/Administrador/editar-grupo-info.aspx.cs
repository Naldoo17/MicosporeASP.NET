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
    public partial class editar_grupo_info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (Page.IsPostBack == false)
            {
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }
                int idGrupo = int.Parse(Request.QueryString["idGrupo"]);
                cargarDatos(idGrupo);
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

        private void cargarDatos(int idGrupo)
        {
            ListItem activo = new ListItem("Activo", "1");
            ListItem inActivo = new ListItem("Inactivo", "0");
            ddlEstado.Items.Add(activo);
            ddlEstado.Items.Add(inActivo);



            ddlTipoModuloInfo.DataSource = InformacionNegocio.ObtenerInformacionAllNegocio().OrderBy(p => p.Nombre);
            ddlTipoModuloInfo.DataValueField = "Id";
            ddlTipoModuloInfo.DataTextField = "Nombre";
            ddlTipoModuloInfo.DataBind();

            GrupoInfoDTO grupo = GrupoInfoNegocio.ObtenerGrupoInfoXID(idGrupo);

            if (grupo==null)
            {
                lblmensaje.Text = "Grupo no encontrado";
                return;
            }

            txtNombre.Text = grupo.Nombre;
            txtTitulo.Text = grupo.Titulo;
            txtDescripcion.Text = grupo.Descripcion;
            ddlEstado.SelectedValue = grupo.Estado.ToString();
            ddlTipoModuloInfo.SelectedValue = grupo.Id_Info.ToString();
            hdImg.Value = grupo.Img;

        }

        protected void btnGuardarGrupo_Click(object sender, EventArgs e)
        {
            try
            {
                int idGrupo = int.Parse(Request.QueryString["idGrupo"]);
                GrupoInfoDTO grupo = new GrupoInfoDTO();
                grupo.Id = idGrupo;
                grupo.Nombre = txtNombre.Text;
                grupo.Titulo = txtTitulo.Text;
                grupo.Descripcion = txtDescripcion.Text;
                grupo.Estado = int.Parse(ddlEstado.SelectedValue);
                grupo.Id_Info = int.Parse(ddlTipoModuloInfo.SelectedValue);

                if (FileUploadImagen.HasFile)
                {
                    string filename = Path.GetFileName(FileUploadImagen.FileName);
                    FileUploadImagen.SaveAs(Server.MapPath("~/img/") + filename);
                    grupo.Img = filename;

                    if (GrupoInfoNegocio.ActualizarGrupoInfoConImagen(grupo))
                    {
                        lblmensaje.Text = "Grupo actualizado correctamente con imagen";
                        limpiar();
                    }
                    else
                    {
                        lblmensaje.Text = "Error al actualizar";
                    }
                }
                else
                {
                    if (GrupoInfoNegocio.ActualizarGrupoInfoSinImagen(grupo))
                    {
                        lblmensaje.Text= lblmensaje.Text = "Grupo actualizado correctamente sin imagen";
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
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            txtTitulo.Text = "";
        }

    }
}