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
    public partial class frmCritica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet lista;
            if (!Page.IsPostBack)
            {
                CadCritica oCadCritica = new CadCritica();
                lista = oCadCritica.consultarTodos();

                if (lista != null)
                {
                    gdvCadCritica.DataSource = lista;
                    gdvCadCritica.DataMember = "Tabela";
                    gdvCadCritica.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CadCritica objCadCritica = new CadCritica();
            objCadCritica.inserir(txtNome.Text,txtCritica.Text,txtData.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            CadCritica objCadCritica = new CadCritica();
            objCadCritica.alterar(txtidCritica.Text, txtNome.Text, txtCritica.Text, txtData.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            CadCritica objCadCritica = new CadCritica();
            objCadCritica.apagar(txtidCritica.Text,txtNome.Text,txtCritica.Text,txtData.Text);
            Response.Redirect(Request.RawUrl);
        }


        protected void gdvCadCritica_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvCadCritica.SelectedRow;

            txtidCritica.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtNome.Text = Server.HtmlDecode(row.Cells[2].Text);
            txtData.Text = Server.HtmlDecode(row.Cells[4].Text);
            txtCritica.Text = Server.HtmlDecode(row.Cells[3].Text);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("reTodasCriticas.aspx");
        }
    }
}