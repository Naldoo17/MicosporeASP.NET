using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Presentacion
{
    public partial class MasterAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                lblCliente.Text = (string)Session["user"];
            }
        }

        protected void linkCerrarSession_Click(object sender, EventArgs e)
        {
            Session["user"] = "";
            Session["rutUser"] = "";
            Session["idTipoUser"] = "";
            Session.RemoveAll();
            Session.Abandon();
            Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);

            Response.Cache.SetAllowResponseInBrowserHistory(false);

            Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.AppendHeader("Cache-Control", "no-store");
            Response.Redirect("../index.aspx");
        }

        //protected void btnCerrarSesion_Click(object sender, EventArgs e)
        //{

        //    Session["user"] = "";
        //    Session["rutUser"] = "";
        //    Session["idTipoUser"] = "";
        //    Session.RemoveAll();
        //    Session.Abandon();
        //    Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
        //    Response.AppendHeader("Cache-Control", "no-store");
        //    Response.Redirect("../index.aspx");
        //}
    }
}