using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExercicio
{
    public partial class frmCadCidade : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CadEstado oCadEstado = new CadEstado();
                lista = oCadEstado.consultarTodos();
                
                cboEstado.DataTextField = "sigla";
                cboEstado.DataValueField = "id";
                cboEstado.DataSource = lista;
                cboEstado.DataMember = "Tabela";
                cboEstado.DataBind();
                cboEstado.Items.Insert(0,"Selecione");
                cboEstado.SelectedIndex = 0 ;

                CadCidade oCadCidade = new CadCidade();
                lista = oCadCidade.consultarTodos();

                if (lista != null)
                {
                    gdvCadCidade.DataSource = lista;
                    gdvCadCidade.DataMember = "Tabela";
                    gdvCadCidade.DataBind();
                }
            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            if (cboEstado.SelectedValue.Equals(0))
            {
                
            }
            else
            {
                CadCidade objCadCidade = new CadCidade();
                objCadCidade.inserir(cboEstado.SelectedValue, txtcidade.Text);
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            CadCidade objCadCidade = new CadCidade();
            objCadCidade.alterar(cboEstado.SelectedValue, txtcidade.Text, txtidCadCidade.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnApagar_Click(object sender, EventArgs e)
        {
            CadCidade objCadCidade = new CadCidade();
            objCadCidade.apagar(txtidCadCidade.Text, txtcidade.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvCadCidade.SelectedRow;

            txtidCadCidade.Text = Server.HtmlDecode(row.Cells[1].Text);
            cboEstado.SelectedValue = Server.HtmlDecode(row.Cells[4].Text);
            txtcidade.Text = Server.HtmlDecode(row.Cells[3].Text);
        }
    }
}