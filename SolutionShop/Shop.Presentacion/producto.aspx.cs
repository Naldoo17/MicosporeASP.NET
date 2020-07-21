using Shop.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Presentacion
{
    public partial class producto : System.Web.UI.Page
    {
        DataTable dtb;
        DataTable carrito = new DataTable();



        public void CargarDetalle()
        {
            if (Session["pedido"] == null)
            {

                dtb = new DataTable("Carrito");
                dtb.Columns.Add("idProducto", System.Type.GetType("System.Int32"));
                dtb.Columns.Add("nombreProducto", System.Type.GetType("System.String"));
                dtb.Columns.Add("descripcion", System.Type.GetType("System.String"));
                dtb.Columns.Add("precio", System.Type.GetType("System.Double"));
                dtb.Columns.Add("subtotal", System.Type.GetType("System.Double"));
                dtb.Columns.Add("canproducto", System.Type.GetType("System.Int32"));

                Session["pedido"] = dtb;
                Session["prueba"] = dtb;
            }
            else
            {
                //Session["pedido"] = Session["prueba"];
            }
        }

        public void AgregarItem(string cod,string nom, string des, double precio)
        {
            double total;
            int cantidad = 1;
            total = precio * cantidad;
            carrito = (DataTable)Session["pedido"];
            DataRow fila = carrito.NewRow();
            fila[0] = cod;
            fila[1] = nom;
            fila[2] = des;
            fila[3] = precio;
            fila[4] = (int)cantidad;
            fila[5] = total;
            carrito.Rows.Add(fila);
            Session["pedido"] = carrito;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null && Session["rutUser"] != null && Session["idTipoUser"] != null)
            {
                string user = (string)Session["user"];
                string rutUser = (string)Session["rutUser"];
                string idTipoUser = Session["idTipoUser"].ToString();
                Redireccionar(user, rutUser, idTipoUser);
            }
            else
            {
                if (Page.IsPostBack == false)
                {
                    CargarDatos();
                    CargarDetalle();
                }
            }
        }

        private void CargarDatos()
        {
           int  idTipo = int.Parse(Request.QueryString["idTipo"].ToString());
            //dlProductos.DataSource = ProductoNegocio.ObtenerProductosAllNegocio().Where(p => p.TipoProducto == idTipo && p.Estado == 1).ToList();
            //dlProductos.DataBind();
            lvProductos.DataSource = ProductoNegocio.ObtenerProductosAllNegocio().Where(p => p.TipoProducto == idTipo && p.Estado == 1).ToList();
            lvProductos.DataBind();
        }

        public void Redireccionar(string user, string rutUser, string idTipoUser)
        {
            switch (int.Parse(idTipoUser))
            {
                case 1:
                    Response.Redirect("~/Administrador/index.aspx", false);
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        protected void ListView1_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            string id;
            string des = null, nom = null;
            double precio = 0;
            
            if (e.CommandName=="Seleccione")
            {
                lvProductos.SelectedIndex = e.Item.DataItemIndex;

                //id = ((Label)(this.lvProductos.SelectItem.FindControl("lblId"))).Text;
                id = ((Label)(this.lvProductos.Items[lvProductos.SelectedIndex].FindControl("lblId"))).Text;
                nom= ((Label)(this.lvProductos.Items[lvProductos.SelectedIndex].FindControl("lblNombre"))).Text;
                des = ((Label)(this.lvProductos.Items[lvProductos.SelectedIndex].FindControl("lblDescripcion"))).Text;
                precio = double.Parse(((Label)(this.lvProductos.Items[lvProductos.SelectedIndex].FindControl("lblPrecio"))).Text);

                AgregarItem(id.ToString(),nom,des,precio);


            }


        }
    }
}