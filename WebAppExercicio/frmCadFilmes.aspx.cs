using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;

namespace WebAppExercicio
{
    public partial class frmCadFilmes : System.Web.UI.Page
    {
        DataSet lista;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Categoria oCategoria = new Categoria();
                lista = oCategoria.consultarTodos();

                cboClassificacao.DataTextField = "Descrição";
                cboClassificacao.DataValueField = "id";
                cboClassificacao.DataSource = lista;
                cboClassificacao.DataMember = "Tabela";
                cboClassificacao.DataBind();
                cboClassificacao.Items.Insert(0, "Selecione");
                cboClassificacao.SelectedIndex = 0;

                Genero oGenero = new Genero();
                lista = oGenero.consultarTodos();

                cboGenero.DataTextField = "Genero";
                cboGenero.DataValueField = "id";
                cboGenero.DataSource = lista;
                cboGenero.DataMember = "Tabela";
                cboGenero.DataBind();
                cboGenero.Items.Insert(0, "Selecione");
                cboGenero.SelectedIndex = 0;

                CadFilmes oCadFilmes = new CadFilmes();
                lista = oCadFilmes.consultarTodos();

                if (lista != null)
                {
                    gdvCadFilmes.DataSource = lista;
                    gdvCadFilmes.DataMember = "Tabela";
                    gdvCadFilmes.DataBind();
                }
            }
        }


        protected void btnInserir_Click(object sender, EventArgs e)
        {
            CadFilmes objCadFilmes = new CadFilmes();
            objCadFilmes.inserir(txtNomeFilme.Text, cboClassificacao.SelectedValue, cboGenero.SelectedValue, txtIframe.Text, txtURLImagem.Text, txtNota.Text, txtDataLacamento.Text, txtAtoresPrincipais.Text, txtNacionalidade.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            CadFilmes objCadFilmes = new CadFilmes();
            objCadFilmes.alterar(txtNomeFilme.Text, cboClassificacao.SelectedValue, cboGenero.SelectedValue, txtIframe.Text, txtURLImagem.Text, txtNota.Text, txtDataLacamento.Text, txtAtoresPrincipais.Text, txtNacionalidade.Text, txtidFilmes.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnApagar_Click1(object sender, EventArgs e)
        {
            CadFilmes objCadFilmes = new CadFilmes();
            objCadFilmes.apagar(txtidFilmes.Text, txtNomeFilme.Text, cboClassificacao.SelectedValue, cboGenero.SelectedValue, txtIframe.Text, txtURLImagem.Text, txtNota.Text, txtDataLacamento.Text, txtAtoresPrincipais.Text, txtNacionalidade.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void gdvCadFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvCadFilmes.SelectedRow;

            txtidFilmes.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtNomeFilme.Text = Server.HtmlDecode(row.Cells[2].Text);
            cboClassificacao.SelectedValue = Server.HtmlDecode(row.Cells[3].Text);
            cboGenero.SelectedValue = Server.HtmlDecode(row.Cells[4].Text);
            txtIframe.Text = Server.HtmlDecode(row.Cells[8].Text);
            txtURLImagem.Text = Server.HtmlDecode(row.Cells[9].Text);
            txtNota.Text = Server.HtmlDecode(row.Cells[5].Text);
            txtDataLacamento.Text = Server.HtmlDecode(row.Cells[10].Text);
            txtAtoresPrincipais.Text = Server.HtmlDecode(row.Cells[6].Text);
            txtNacionalidade.Text = Server.HtmlDecode(row.Cells[7].Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmRelatorioFilmes.aspx");
        }
    }
}