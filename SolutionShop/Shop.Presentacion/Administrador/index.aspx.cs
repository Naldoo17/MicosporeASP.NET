using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Presentacion.Administrador
{
    public partial class index : System.Web.UI.Page
    {
        public string Url = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }

                //lblNombre.Text = (string)Session["correo"];

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

        //protected void lbInfo_Click(object sender, EventArgs e)
        //{
        //    Url = "informacion.aspx";
        //}

        //public static void recibeDatosHijo(string funcion)
        //{
        //    Page currentPage =(Page)HttpContext.Current.Handler;
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(funcion);
        //    ScriptManager.RegisterStartupScript(currentPage,currentPage.GetType(),"OpenWindow",sb.ToString(),true);
        //}

        //public static void enviaDatos(Object control,string nombreFuncion,string funcion)
        //{
        //    Page currentPage = (Page)HttpContext.Current.Handler;
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(funcion);
        //    ScriptManager.RegisterStartupScript(currentPage, currentPage.GetType(), "OpenWindow", sb.ToString(), true);
            
        //}

    }
}


