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
    public partial class frmCadCategoria : System.Web.UI.Page
    {
        DataSet lista;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Categoria oCategoria = new Categoria();
                lista = oCategoria.consultarTodos();

                if (lista != null)
                {
                    gdvCadCategoria.DataSource = lista;
                    gdvCadCategoria.DataMember = "Tabela";
                    gdvCadCategoria.DataBind();
                }
            }
        }

        protected void gdvCadCategoria_SelectedIndexChanged1(object sender, EventArgs e)
        {
            GridViewRow row = gdvCadCategoria.SelectedRow;
            txtidCategoria.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtdescricao.Text = Server.HtmlDecode(row.Cells[2].Text);
            txtNdoFilme.Text = Server.HtmlDecode(row.Cells[3].Text);
        }

        protected void btnInserir_Click1(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.inserir(txtdescricao.Text, txtNdoFilme.Text);
        }

        protected void btnAlterar_Click1(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.alterar(txtdescricao.Text, Convert.ToInt32(txtNdoFilme.Text));
            Response.Redirect(Request.RawUrl);
        }

        protected void btnApagar_Click1(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.apagar(txtidCategoria.Text, txtdescricao.Text, Convert.ToInt32(txtNdoFilme.Text));
            Response.Redirect(Request.RawUrl);
        }

    }
}