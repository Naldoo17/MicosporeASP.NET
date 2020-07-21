using Shop.DTO;
using Shop.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Shop.Presentacion.Administrador
{
    public partial class mantenedor_tipoInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (Page.IsPostBack == false)
            {
                if (Session["user"] == null || Session["correo"] == null || Session["idTipoUser"] == null || Session["idTipoUser"].ToString() != "1")
                {
                    Response.Redirect("../index.aspx");
                }
                btnActualizar.Visible = false;
                cargarGrilla();
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

        public void cargarGrilla()
        {
            GvTipoInfo.DataSource = TipoInfoNegocio.ObtenerTiposInfo();
            GvTipoInfo.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombreTipoInfo.Text.Equals(""))
                {
                    lblmensaje.Text = "Ingrese nombre tipo información";
                    return;
                }
                TipoInfoDTO tipo = new TipoInfoDTO();
                tipo.Nombre = txtNombreTipoInfo.Text;
                if (TipoInfoNegocio.CrearTipoInfo(tipo))
                {
                    lblmensaje.Text = "Ingresado Correctamente";
                    limpiar();
                    cargarGrilla();
                }
                else
                {
                    lblmensaje.Text = "Error, no se pudo ingresar";
                }
            }
            catch (Exception ex)
            {

                lblmensaje.Text = ex.Message;
            }
        }

        private void limpiar()
        {
            txtNombreTipoInfo.Text = "";

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                TipoInfoDTO tipo = null;
                int id = 0;

                for (int i = 0; i <= GvTipoInfo.Rows.Count - 1; i++)
                {
                    bool bChequeado = ((HtmlInputRadioButton)GvTipoInfo.Rows[i].FindControl("RadioButton1")).Checked;
                    if (bChequeado)
                    {

                        id = Convert.ToInt32(GvTipoInfo.DataKeys[GvTipoInfo.Rows[i].RowIndex][0].ToString());

                        break;
                    }
                }
                if (id == 0)
                {
                    lblmensaje.Text = "Seleccione un valor";
                    return;

                }
                tipo = TipoInfoNegocio.ObtenerTipoInfoFiltroID(id);
                if (tipo == null)
                {
                    lblmensaje.Text = "No se encuentran datos";
                }
                else
                {
                    txtNombreTipoInfo.Text = tipo.Nombre;
                    hdId.Value = tipo.Id.ToString();
                    btnActualizar.Visible = true;
                    btnAgregar.Visible = false;
                }


            }
            catch (Exception ex)
            {

                lblmensaje.Text = ex.Message;
            }


        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                TipoInfoDTO tipo = new TipoInfoDTO();
                tipo.Id = int.Parse(hdId.Value);
                tipo.Nombre = txtNombreTipoInfo.Text;

                if (TipoInfoNegocio.ActualizarTipoInfo(tipo))
                {
                    lblmensaje.Text = "Actualizado correctamente";
                    hdId.Value = "";
                    limpiar();
                    btnActualizar.Visible = false;
                    btnAgregar.Visible = true;
                    cargarGrilla();
                }
                else
                {
                    lblmensaje.Text = "Error, no se pudo actualizar";
                }
            }
            catch (Exception ex)
            {

                lblmensaje.Text = ex.Message;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;


                for (int i = 0; i <= GvTipoInfo.Rows.Count - 1; i++)
                {
                    bool bChequeado = ((HtmlInputRadioButton)GvTipoInfo.Rows[i].FindControl("RadioButton1")).Checked;
                    if (bChequeado)
                    {

                        id = Convert.ToInt32(GvTipoInfo.DataKeys[GvTipoInfo.Rows[i].RowIndex][0].ToString());

                        break;
                    }
                }
                if (id == 0)
                {
                    lblmensaje.Text = "Seleccione un valor";
                    return;

                }
                TipoInfoDTO tipo = new TipoInfoDTO();
                tipo.Id = id;
                if (TipoInfoNegocio.EliminarTipoInfo(tipo))
                {
                    lblmensaje.Text = "Eliminado correctamente";
                    cargarGrilla();
                }
                else
                {
                    lblmensaje.Text = "Error, no se pudo eliminar";
                }
            }
            catch (Exception ex)
            {

                lblmensaje.Text = ex.Message;
            }
        }
    }
}