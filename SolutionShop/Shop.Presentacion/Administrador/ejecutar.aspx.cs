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
    public partial class ejecutar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Page.IsPostBack == false)
            {
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }
                else
                {
                    int funcion = int.Parse(Request.QueryString["ejecutar"].ToString());


                    switch (funcion)
                    {
                        case 1:
                            eliminar_productos();
                            break;
                        case 2:
                            eliminarTipoProducto();
                            break;
                        default:
                            break;
                    }


                }
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

        //}

        private void eliminar_productos()
        {
            int idProd = int.Parse(Request.QueryString["idProd"].ToString());
            int idTipo = int.Parse(Request.QueryString["idTipo"].ToString());

            ProductoDTO producto = new ProductoDTO();
            producto.IdProducto = idProd;
            ProductoNegocio.EliminarProducto(producto);
            Response.Redirect("Productos.aspx?idTipo=" + idTipo);


        }

        private void eliminarTipoProducto()
        {
            //int idTipoProd = int.Parse(Request.QueryString["idProd"].ToString());
            int idTipo = int.Parse(Request.QueryString["idTipo"].ToString());
            TipoProductoDTO tipo = new TipoProductoDTO();
            tipo.idTipoProducto = idTipo;
            TipoProductoNegocio.EliminaTipoProducto(tipo);
            
            Response.Redirect("lista-productos.aspx");
        }
    }
}