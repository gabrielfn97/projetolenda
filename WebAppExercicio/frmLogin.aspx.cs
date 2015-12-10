using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Negocio;


namespace WebAppExercicio
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click1(object sender, EventArgs e)
        {
            Usuarios objLogar = new Usuarios();
            objLogar.logar(txtLogin.Text, txtSenha.Text);
        }
    }
}