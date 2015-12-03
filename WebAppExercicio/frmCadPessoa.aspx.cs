using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebAppExercicio
{
    public partial class frmCadPessoa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Pessoas oPessoa = new Pessoas();
            oPessoa.inserir(txtCPF.Text, txtNome.Text, txtDataNascimento.Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}