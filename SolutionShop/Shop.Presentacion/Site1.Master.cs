using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Presentacion
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

               
                if (Session["user"] != null && Session["rutUser"] != null && Session["idTipoUser"] != null)
                {
                    string user = (string)Session["user"];
                    string rutUser = (string)Session["rutUser"];
                    string idTipoUser = Session["idTipoUser"].ToString();
                    Redireccionar(user,rutUser,idTipoUser);
                }
            }
        }

        //protected void btnInstagram_Click(object sender, ImageClickEventArgs e)
        //{
        //    Response.Write("<script>window.open('http://www.somesite.com/','_blank');</script>");
        //}

        public void Redireccionar(string user, string rutUser, string idTipoUser)
        {
            switch (int.Parse(idTipoUser))
            {
                case 1:
                    Response.Redirect("/Administrador/index.aspx", false);
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}