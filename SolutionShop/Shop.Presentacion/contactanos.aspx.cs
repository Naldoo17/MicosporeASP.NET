using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shop.Presentacion
{
    public partial class contactanos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = new DateTime(Convert.ToDateTime(txtFechaNacimiento.Text).Year, Convert.ToDateTime(txtFechaNacimiento.Text).Month, Convert.ToDateTime(txtFechaNacimiento.Text).Day); //Fecha de nacimiento ao mes dia



            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;

            //lblMensaje.Text = edad.ToString();

            if (edad >= 18)
            {


                //System.Net.Mail.MailMessage mensaje = new System.Net.Mail.MailMessage();
                //mensaje.To.Add("micospore@gmail.com");
                //mensaje.Subject = "[WEB SITE] Consulta de: " + txtNombre.Text + " mediante sitio web";
                //mensaje.SubjectEncoding = System.Text.Encoding.UTF8;

                //mensaje.Body = "Mensaje enviado desde: " + txtEmail.Text + ". Consulta realizada por cliente: " + txtComentarios.Text;
                //mensaje.BodyEncoding = System.Text.Encoding.UTF8;
                //mensaje.IsBodyHtml = true;
                //mensaje.From = new System.Net.Mail.MailAddress("micospore@gmail.com");

                //System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                //cliente.Credentials = new System.Net.NetworkCredential("micospore@gmail.com", "Lucho2020.");
                //cliente.Port = 587;
                //cliente.EnableSsl = true;
                //cliente.Host = "smtp.gmail.com";



                System.Net.Mail.MailMessage mensaje = new System.Net.Mail.MailMessage();
                mensaje.To.Add("contacto@micospore.cl");
                mensaje.Subject = "[WEB SITE] Consulta de: " + txtNombre.Text + " mediante sitio web";
                mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
                mensaje.Priority = MailPriority.Normal;
                mensaje.Body = "Mensaje enviado desde: " + txtEmail.Text + ". Consulta realizada por cliente: " + txtComentarios.Text;
                mensaje.BodyEncoding = System.Text.Encoding.UTF8;
                mensaje.IsBodyHtml = true;
                mensaje.From = new System.Net.Mail.MailAddress("contacto@micospore.cl");

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "mail.micospore.cl";
                smtp.Port = 25;
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("contacto@micospore.cl", "Lucho2020.");

                //string output = null;

                try
                {
                    smtp.Send(mensaje);
                    mensaje.Dispose();
                    txtComentarios.Text = "";
                    txtNombre.Text = "";
                    txtEmail.Text = "";
                    txtFechaNacimiento.Text = new DateTime(2008, 5, 1).ToString();

                    lblMensaje.Text = "Tu mensaje ha sido enviado exitósamente. Nos contactaremos contigo mediante correo electrónico.";
                }
                catch (Exception ex)
                {
                    //lblMensaje.Text = "Ha habido un problema con el envio de tu solicitud, por favor intente nuevamente";
                    lblMensaje.Text = ex.Message;
                }
            }
            else
            {
                lblMensaje.Text = "Lo sentimos pero para realizar solicitud debes ser mayor de 18 años";
            }
        }

        //protected void btnEnviar_Click(object sender, EventArgs e)
        //{
        //    DateTime nacimiento = new DateTime(Convert.ToDateTime(txtFechaNacimiento.Text).Year, Convert.ToDateTime(txtFechaNacimiento.Text).Month, Convert.ToDateTime(txtFechaNacimiento.Text).Day); //Fecha de nacimiento ao mes dia



        //    int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;

        //    //lblMensaje.Text = edad.ToString();

        //    if (edad >= 18)
        //    {


        //        System.Net.Mail.MailMessage mensaje = new System.Net.Mail.MailMessage();
        //        mensaje.To.Add("micospore@gmail.com");
        //        mensaje.Subject = "[WEB SITE] Consulta de: " + txtNombre.Text + " mediante sitio web";
        //        mensaje.SubjectEncoding = System.Text.Encoding.UTF8;

        //        mensaje.Body = "Mensaje enviado desde: " + txtEmail.Text + ". Consulta realizada por cliente: " + txtComentarios.Text;
        //        mensaje.BodyEncoding = System.Text.Encoding.UTF8;
        //        mensaje.IsBodyHtml = true;
        //        mensaje.From = new System.Net.Mail.MailAddress("micospore@gmail.com");

        //        System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
        //        cliente.Credentials = new System.Net.NetworkCredential("micospore@gmail.com", "Lucho2020.");
        //        cliente.Port = 587;
        //        cliente.EnableSsl = true;
        //        cliente.Host = "smtp.gmail.com";

        //        try
        //        {
        //            cliente.Send(mensaje);
        //            txtComentarios.Text = "";
        //            txtNombre.Text = "";
        //            txtEmail.Text = "";
        //            txtFechaNacimiento.Text = new DateTime(2008, 5, 1).ToString();

        //            lblMensaje.Text = "Tu mensaje ha sido enviado exitósamente. Nos contactaremos contigo mediante correo electronico. Saludos Atte Micospore";
        //        }
        //        catch (Exception ex)
        //        {
        //            lblMensaje.Text = "Ha habido un problema con el envio de tu solicitud, por favor intente nuevamente";
        //        }
        //    }
        //    else
        //    {
        //        lblMensaje.Text = "Lo sentimos pero para realizar solicitud debes ser mayor de 18 años";
        //    }
        //}




    }
}
