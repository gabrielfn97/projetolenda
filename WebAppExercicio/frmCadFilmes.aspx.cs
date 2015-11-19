using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExercicio
{
    public partial class frmCadFilmes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            CadFilmes oCadFilmes = new CadFilmes();
            oCadFilmes.inserir(txtNomeFilme.Text, txtClassificacao.Text, txtGenero.Text, txtIframe.Text, txtURLImagem.Text, txtNota.Text, txtDataLancamento.Text, txtAtoresPrincipais.Text, txtNacionalidade.Text);
        }
    }
}