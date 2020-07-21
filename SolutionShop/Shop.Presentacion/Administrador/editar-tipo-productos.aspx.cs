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
    public partial class editar_tipo_productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Page.IsPostBack==false)
            {
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }

                int id = int.Parse(Request.QueryString["idTipo"].ToString());
                ListItem activo = new ListItem("Activo", "1");
                ListItem inActivo = new ListItem("Inactivo", "0");
                ddlEstado.Items.Add(activo);
                ddlEstado.Items.Add(inActivo);
                CargaDatos(id);
            }
            else
            {
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }
            }

            Response.AppendHeader("Cache-Control", "no-store");
        }

        private void CargaDatos(int id)
        {
            TipoProductoDTO tipoProducto = TipoProductoNegocio.ObtenerTipoProductoFiltroID(id);
            txtDescripcionNuevo.Text = tipoProducto.descripcion;
            txtNombreTipoProd.Text = tipoProducto.nombreProducto;
            ddlEstado.SelectedValue = tipoProducto.activo.ToString();
            if (tipoProducto.img != null)
            {
                hdImg.Value = tipoProducto.img.ToString();
            }

            

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoProductoDTO tipoProducto = new TipoProductoDTO();
                tipoProducto.idTipoProducto = int.Parse(Request.QueryString["idTipo"].ToString());
                tipoProducto.nombreProducto = txtNombreTipoProd.Text;               
                tipoProducto.descripcion = txtDescripcionNuevo.Text;
                //tipoProducto.activo = 1;
                tipoProducto.activo = int.Parse(ddlEstado.SelectedValue);
                if (FileUploadImagen.HasFile)
                {
                    string nombreArchivo = Path.GetFileName(FileUploadImagen.FileName);
                    FileUploadImagen.SaveAs(Server.MapPath("~/img/") + nombreArchivo);
                    tipoProducto.img = nombreArchivo;
                    if (TipoProductoNegocio.ActualizaTipoProductoConImagen(tipoProducto))
                    {
                        lblmensaje.Text = "Tipo producto Con imagen actualizado";
                    }
                    else
                    {
                        lblmensaje.Text = "Error, No fue posible actualizar";
                    }
                }
                else
                {
                    if (TipoProductoNegocio.ActualizaTipoProductoSinImagen(tipoProducto))
                    {
                        lblmensaje.Text = "Tipo producto sin imagen actualizado";
                    }
                    else
                    {
                        lblmensaje.Text = "Error, No fue posible actualizar";
                    }
                }
            }
            catch (Exception ex)
            {
                lblmensaje.Text = ex.Message;
               
            }
        }
    }
}