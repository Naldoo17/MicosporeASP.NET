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
    public partial class mantenedor_productos : System.Web.UI.Page
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


        protected void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (FileUploadImagen.HasFile)
            {

                try
                {
                    string filename = Path.GetFileName(FileUploadImagen.FileName);
                    FileUploadImagen.SaveAs(Server.MapPath("~/img/") + filename);
                    ProductoDTO producto = new ProductoDTO();
                    producto.NombreProducto = txtNombrePrododucto.Text;
                    producto.Descripcion = txtDescripcion.Text;
                    producto.Stock = int.Parse(txtStock.Text);
                    producto.Precio = int.Parse(txtPrecio.Text);
                    producto.TipoProducto = int.Parse(ddlTipoProducto.SelectedValue);
                    producto.Img = filename.ToString();
                    producto.Estado = 1;
                    if (ProductoNegocio.CrearProductoNegocio(producto))
                    {
                        lblmensaje.Text = "Producto ingresado exitosamente";

                    }
                    else
                    {
                        lblmensaje.Text = "Errorn al ingresar producto";
                    }
                }
                catch (Exception ex)
                {

                    lblmensaje.Text = ex.Message.ToString(); ;
                }
            }
            else
            {
                lblmensaje.Text = "Imagen del producto no se ha cargado";
            }
        }
    }
}