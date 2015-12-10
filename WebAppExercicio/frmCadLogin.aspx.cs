using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExercicio
{
    public partial class frmCadLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Usuarios objCadLogin = new Usuarios();
            objCadLogin.inserir(txtEmail.Text, txtSenha.Text, txtUsuario.Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Usuarios objCadLogin = new Usuarios();
            objCadLogin.alterar(txtEmail.Text, txtSenha.Text, txtUsuario.Text, txtidCadLogin.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnApagar_Click(object sender, EventArgs e)
        {

            Usuarios objCadLogin = new Usuarios();
            objCadLogin.apagar(txtEmail.Text, txtSenha.Text, txtUsuario.Text, txtidCadLogin.Text);
            Response.Redirect(Request.RawUrl);
        }
    }
}