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
    public partial class editar_productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (Page.IsPostBack == false)
            {
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }

                List<TipoProductoDTO> lista = new List<TipoProductoDTO>();
                lista = TipoProductoNegocio.ObtenerTipoProductosAll();
                ddlTipoProducto.DataSource = lista;
                ddlTipoProducto.DataTextField = "nombreProducto";
                ddlTipoProducto.DataValueField = "idTipoProducto";
                ddlTipoProducto.DataBind();
                int id = int.Parse(Request.QueryString["idProd"].ToString());
                CargaDatos(id);

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

        private void CargaDatos(int id)
        {
            ProductoDTO producto = ProductoNegocio.ObtenerProductoFiltroID(id);
            txtNombrePrododucto.Text = producto.NombreProducto;
            ddlTipoProducto.SelectedValue = producto.TipoProducto.ToString();
            txtPrecio.Text = producto.Precio.ToString();
            txtDescripcion.Text = producto.Descripcion;
            hdImagen.Value = producto.Img.ToString();
        }

        protected void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoDTO producto = new ProductoDTO();
                producto.IdProducto = int.Parse(Request.QueryString["idProd"].ToString());
                producto.NombreProducto = txtNombrePrododucto.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Precio = int.Parse(txtPrecio.Text);
                producto.Estado = 1;
                producto.TipoProducto = int.Parse(ddlTipoProducto.SelectedValue);

                if (FileUploadImagen.HasFile)
                {
                    string filename = Path.GetFileName(FileUploadImagen.FileName);
                    FileUploadImagen.SaveAs(Server.MapPath("~/img/") + filename);
                    producto.Img = filename;
                    if (ProductoNegocio.ActualizarProducto(producto, 2))
                    {
                        lblmensaje.Text = "Producto actualizado correctamente";
                    }
                    else
                    {
                        lblmensaje.Text = "Error, no se pudo actualizar producto";
                    }

                }
                else
                {
                    if (ProductoNegocio.ActualizarProducto(producto, 4))
                    {
                        lblmensaje.Text = "Producto actualizado correctamente";
                    }
                    else
                    {
                        lblmensaje.Text = "Error, no se pudo actualizar producto";
                    }
                }


            }
            catch (Exception ex)
            {
                lblmensaje.Text = ex.Message.ToString();
            }
        }
    }
}