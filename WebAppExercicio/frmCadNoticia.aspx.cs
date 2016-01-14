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
    public partial class frmCadNoticia : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CadNoticia oCadNoticia = new CadNoticia();
                lista = oCadNoticia.consultarTodos();

                if (lista != null)
                {
                    gdvCadNoticia.DataSource = lista;
                    gdvCadNoticia.DataMember = "Tabela";
                    gdvCadNoticia.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CadNoticia objCadNoticia = new CadNoticia();
            objCadNoticia.inserir(txtNoticia.Text, txtData.Text, txtTipoNoticia.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            CadNoticia objCadNoticia = new CadNoticia();
            objCadNoticia.alterar(txtidNoticia.Text, txtNoticia.Text, txtData.Text, txtTipoNoticia.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CadNoticia objCadNoticia = new CadNoticia();
            objCadNoticia.alterar(txtidNoticia.Text, txtNoticia.Text, txtData.Text, txtTipoNoticia.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvCadNoticia.SelectedRow;

            txtidNoticia.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtNoticia.Text = Server.HtmlDecode(row.Cells[2].Text);
            txtData.Text = Server.HtmlDecode(row.Cells[3].Text);
            txtTipoNoticia.Text = Server.HtmlDecode(row.Cells[4].Text);
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("reNoticias.aspx");
        }

        

    }
}