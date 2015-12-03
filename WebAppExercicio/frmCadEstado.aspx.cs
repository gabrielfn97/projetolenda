using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebAppExercicio
{
    public partial class frmCadEstado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            CadEstado oCadEstado = new CadEstado();
            oCadEstado.inserir( txtEstado.Text, txtSigla.Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            CadEstado oCadEstado = new CadEstado();
            oCadEstado.alterar(txtEstado.Text, txtSigla.Text);
            Response.Redirect(Request.RawUrl);
        }
    }
}