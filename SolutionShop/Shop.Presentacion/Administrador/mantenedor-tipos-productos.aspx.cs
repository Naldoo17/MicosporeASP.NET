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
    public partial class mantenedor_tipos_productos : System.Web.UI.Page
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

        private void CargaDatos()
        {
            ListItem activo = new ListItem("Activo", "1");
            ListItem inActivo = new ListItem("Inactivo", "0");
            ddlEstado.Items.Add(activo);
            ddlEstado.Items.Add(inActivo);
        }

        //protected void btnGuardarTipoProducto_Click(object sender, EventArgs e)
        //{


        //    if (FileUploadImagen.HasFile)
        //    {

        //        try
        //        {
        //            string filename = Path.GetFileName(FileUploadImagen.FileName);
        //            FileUploadImagen.SaveAs(Server.MapPath("~/img/") + filename);
        //            TipoProductoDTO tipo = new TipoProductoDTO();
        //            tipo.nombreProducto = txtNombreTipoProd.Text;
        //            tipo.descripcion = txtDescripcion.Text;
        //            tipo.activo = 1;
        //            tipo.img = filename.ToString();
        //            if (TipoProductoNegocio.CrearTipoProducto(tipo))
        //            {
        //                lblmensaje.Text = "Tipo producto registrado exitosamente";
        //            }
        //            else
        //            {
        //                lblmensaje.Text = "Error al cargar tipo producto";
        //            }

        //        }
        //        catch (Exception ex)
        //        {

        //            lblmensaje.Text = ex.Message.ToString();
        //        }

        //        lblmensaje.Text = "Debe cargar imagen";
        //    }
        //}

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            if (FileUploadImagen.HasFile)
            {
                try
                {
                    string filename = Path.GetFileName(FileUploadImagen.FileName);
                    FileUploadImagen.SaveAs(Server.MapPath("~/img/") + filename);
                    TipoProductoDTO tipo = new TipoProductoDTO();
                    tipo.nombreProducto = txtNombreTipoProd.Text;
                    tipo.descripcion = txtDescripcion.Text;
                    tipo.activo = int.Parse(ddlEstado.SelectedValue);
                    tipo.img = filename.ToString();
                    if (TipoProductoNegocio.CrearTipoProducto(tipo))
                    {
                        lblmensaje.Text = "Tipo producto registrado exitosamente";
                    }
                    else
                    {
                        lblmensaje.Text = "Error al cargar tipo producto";
                    }

                }
                catch (Exception ex)
                {

                    lblmensaje.Text = ex.Message.ToString();
                }
            }
            else
            {
                lblmensaje.Text = "Debe cargar imagen";
            }
        }
    }
}