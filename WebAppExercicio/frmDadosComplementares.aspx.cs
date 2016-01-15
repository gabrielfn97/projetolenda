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
    public partial class frmDadosComplementares : System.Web.UI.Page
    {
        DataSet lista;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Usuarios objUsuario = new Usuarios();
                lista = objUsuario.consultarTodos();

                cboUsuarios.DataTextField = "usuario";
                cboUsuarios.DataValueField = "idCadLogin";
                cboUsuarios.DataSource = lista;
                cboUsuarios.DataMember = "Tabela";
                cboUsuarios.DataBind();
                cboUsuarios.Items.Insert(0, "Selecione");
                cboUsuarios.SelectedIndex = 0;

                DadosComplementares objDadosComplementares = new DadosComplementares();
                lista = objDadosComplementares.consultarTodos();

                if (lista != null)
                {
                    gdvDadosComplementares.DataSource = lista;
                    gdvDadosComplementares.DataMember = "Tabela";
                    gdvDadosComplementares.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DadosComplementares objDadosComplementares = new DadosComplementares();
            objDadosComplementares.inserir(txtidDadosComplementares.Text, cboUsuarios.SelectedValue, txtEndereco.Text, txtTelefone.Text, txtBairro.Text, txtEstadoCivil.Text, txtImgPerfilUrl.Text, txtDataNascimento.Text, txtSexo.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DadosComplementares objDadosComplementares = new DadosComplementares();
            objDadosComplementares.alterar(txtidDadosComplementares.Text, cboUsuarios.SelectedValue, txtEndereco.Text, txtTelefone.Text, txtBairro.Text, txtEstadoCivil.Text, txtImgPerfilUrl.Text, txtDataNascimento.Text, txtSexo.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DadosComplementares objDadosComplementares = new DadosComplementares();
            objDadosComplementares.apagar(txtidDadosComplementares.Text, txtEndereco.Text, txtTelefone.Text, txtBairro.Text, txtEstadoCivil.Text, txtImgPerfilUrl.Text, txtDataNascimento.Text, txtSexo.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void gdvDadosComplementares_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvDadosComplementares.SelectedRow;

            cboUsuarios.SelectedValue = Server.HtmlDecode(row.Cells[2].Text);
            txtidDadosComplementares.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtEndereco.Text = Server.HtmlDecode(row.Cells[3].Text);
            txtTelefone.Text = Server.HtmlDecode(row.Cells[4].Text);
            txtBairro.Text = Server.HtmlDecode(row.Cells[5].Text);
            txtEstadoCivil.Text = Server.HtmlDecode(row.Cells[6].Text);
            txtImgPerfilUrl.Text = Server.HtmlDecode(row.Cells[7].Text);
            txtDataNascimento.Text = Server.HtmlDecode(row.Cells[8].Text);
            txtSexo.Text = Server.HtmlDecode(row.Cells[9].Text);
        }
     }
        


}
