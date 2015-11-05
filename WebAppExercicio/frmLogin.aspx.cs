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

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            objLogin.inserir(txtLogin.Text, txtSenha.Text);
        }
    }
}