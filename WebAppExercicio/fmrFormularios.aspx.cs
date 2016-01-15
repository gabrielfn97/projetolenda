using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExercicio
{
    public partial class fmrFormularios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmDadosComplementares.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("reNoticiasCinema.aspx");
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmRelatorioFilmes.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmCadCategoria.aspx");
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("reTodasCriticas.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmCadEstado.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmCadNoticia.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmCadCidade.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmCadFilmes.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmCadLogin.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmGeneros.aspx");
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("reNoticias.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmCritica.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmLogin.aspx");
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Response.Redirect("reGeneros.aspx");
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            Response.Redirect("reCidades.aspx");
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            Response.Redirect("reEstados.aspx");
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            Response.Redirect("reClassificacao.aspx");
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            Response.Redirect("reUsuarios.aspx");
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            Response.Redirect("reDadosComplementares.aspx");
        }
    }
}