using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExercicio
{
    public partial class frmRecSenha2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRecSenha_Click(object sender, EventArgs e)
        {
                Usuarios objLogar = new Usuarios();
                objLogar.RecSenha2(txtidCadLogin.Text, txtUsuario.Text, txtSenha.Text);
                Response.Redirect("frmLogin.aspx");
        }
    }
}