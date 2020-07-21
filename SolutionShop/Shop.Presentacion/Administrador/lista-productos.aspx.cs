using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.Negocio;
using Shop.DTO;
using System.Web.Services;

namespace Shop.Presentacion.Administrador
{
    public partial class lista_productos : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }

                CargarGrilla();
                CargarDatos();
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

        private void CargarDatos()
        {

            ddlTipos.DataSource = TipoProductoNegocio.ObtenerTipoProductosAll().OrderBy(p => p.idTipoProducto).ToList();
            ddlTipos.DataValueField = "idTipoProducto";
            ddlTipos.DataTextField = "nombreProducto";
            
            ddlTipos.DataBind();
            ddlTipos.Items.Add(new ListItem("Todos","0"));
            ddlTipos.SelectedValue = "0";
            //ddlTipos.Items.Insert(0,"Todos");
        }

        private void CargarGrilla()
        {
            gvTipoProductos.DataSource = TipoProductoNegocio.ObtenerTipoProductosAll().OrderBy(p => p.nombreProducto).ToList();
            gvTipoProductos.DataBind();
        }


        [WebMethod]
        public static List<ProductoDTO> ListaProductos()
        {

            List<ProductoDTO> lista = new List<ProductoDTO>();
            try
            {
                lista = ProductoNegocio.ObtenerListaProductosJoinTipo();
            }
            catch (Exception ex)
            {

                lista = null;
            }
            return lista;
        }

        protected void gvProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTipoProductos.PageIndex = e.NewPageIndex;
            CargarGrilla();
        }

        protected void linkEditar_Click(object sender, EventArgs e)
        {
            int idTipo = Convert.ToInt32((sender as LinkButton).CommandArgument);
            Response.Redirect("editar-tipo-productos.aspx?idTipo=" + idTipo);
        }

        protected void gvTipoProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }

        protected void linkEliminar_Click(object sender, EventArgs e)
        {
            int idTipo = Convert.ToInt32((sender as LinkButton).CommandArgument);
            TipoProductoDTO tipo = new TipoProductoDTO();
            tipo.idTipoProducto = idTipo;

            if (TipoProductoNegocio.EliminaTipoProducto(tipo))
            {
                Response.Write("<script>alert('Eliminado exitosamente');</script>");
                CargarGrilla();
            }
        }

        protected void ddlTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idTipo = Convert.ToInt32(ddlTipos.SelectedValue.ToString());
            if (idTipo != 0)
            {
                gvTipoProductos.DataSource = TipoProductoNegocio.ObtenerTipoProductosAll().Where(p => p.activo == 1 && p.idTipoProducto == idTipo).OrderBy(p => p.nombreEstado).ToList();
                gvTipoProductos.DataBind();
            }
            else
            {
                CargarGrilla();
            }
            //CargarDatos();
        }
    }
}