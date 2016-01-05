using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExercicio
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            VotacaoFilme objCadFilmes = new VotacaoFilme();
            objCadFilmes.votacao((String) Session["Usuario"], txtidfilme.Value, 1);
        }

        protected void btn2_Click(object sender, ImageClickEventArgs e)
        {
            VotacaoFilme objCadFilmes = new VotacaoFilme();
            objCadFilmes.votacao((String) Session["Usuario"], txtidfilme.Value, 2);
        }

        protected void btn3_Click(object sender, ImageClickEventArgs e)
        {
            VotacaoFilme objCadFilmes = new VotacaoFilme();
            objCadFilmes.votacao((String) Session["Usuario"], txtidfilme.Value, 3);
        }

        protected void btn4_Click(object sender, ImageClickEventArgs e)
        {
            VotacaoFilme objCadFilmes = new VotacaoFilme();
            objCadFilmes.votacao((String)Session["Usuario"], txtidfilme.Value, 4);
        }

        protected void btn5_Click(object sender, ImageClickEventArgs e)
        {
            VotacaoFilme objCadFilmes = new VotacaoFilme();
            objCadFilmes.votacao((String)Session["Usuario"], txtidfilme.Value, 5);
        }
    }
}