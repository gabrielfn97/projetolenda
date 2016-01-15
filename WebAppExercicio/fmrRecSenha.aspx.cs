using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExercicio
{
    public partial class fmrRecSenha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRecSenha_Click(object sender, EventArgs e)
        {
            Usuarios objLogar =  new Usuarios();
            objLogar.RecSenha(txtidCadLogin.Text,txtEmail.Text, txtUsuario.Text);

            if (objLogar.idUsuario != null)
            {
                Session["Usuario"] = objLogar.idUsuario;
                Response.Redirect("frmRecSenha2.aspx");
            }
            else
            {
                Response.Redirect(Request.RawUrl);
            }
        }
    }
}