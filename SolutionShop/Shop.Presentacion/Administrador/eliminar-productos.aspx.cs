using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.DTO;
using Shop.Negocio;

namespace Shop.Presentacion.Administrador
{
    public partial class eliminar_productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }


                btnEliminar_Click(null, null);

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

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["idProd"].ToString());
            ProductoDTO producto = new ProductoDTO();
            producto.IdProducto = id;
            bool ejecutar = false;
            ejecutar = ProductoNegocio.EliminarProducto(producto);
            Response.Redirect("lista-productos.aspx");

        }
    }
}