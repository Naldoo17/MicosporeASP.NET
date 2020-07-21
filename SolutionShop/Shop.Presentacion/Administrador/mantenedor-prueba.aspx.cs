using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shop.DTO;
using Shop.Negocio;
namespace Shop.Presentacion.Administrador
{
    public partial class mantenedor_prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                cargarGrilla();
            }
        }

        private void cargarGrilla()
        {
            gvComunas.DataSource = ComunaNegocio.ObtenerComunasAll();
            gvComunas.DataBind();

        }

        [WebMethod]
        public static bool registrarComuna(ComunaDTO objComuna)
        {
            //mantenedor_prueba prueba = new mantenedor_prueba();
            //prueba.cargarGrilla();
            //return objComuna.Nombre;

            try
            {
                if (ComunaNegocio.crearComunaNegocio(objComuna))
                {
                    return true;
                }
                else
                {
                    return false;
                }

                
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        
    }
}