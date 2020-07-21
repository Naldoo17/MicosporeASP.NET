using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Presentacion
{
    public partial class carrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                cargarDatos();

            }
        }

        private void cargarDatos()
        {
            GvCarrito.DataSource = Session["pedido"];
            GvCarrito.DataBind();
        }

        protected void GvCarrito_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        

        protected void GvCarrito_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {

        }

        protected void GvCarrito_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = e.RowIndex;
            DataTable dt1 = new DataTable();
            dt1 = (DataTable)Session["pedido"];
            dt1.Rows[index].Delete();

            //lblTotal.Text = TotalCarrito(dt1).ToString();
            GvCarrito.DataSource = dt1;
            GvCarrito.DataBind();
            Session["pedido"] = dt1;
        }

        protected void GvCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}