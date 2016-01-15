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
    public partial class frmcategoriasfilmes : System.Web.UI.Page
    {
        DataSet lista;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Genero oGenero = new Genero();
                lista = oGenero.consultarTodos();

                if (lista != null)
                {
                    gdvGeneros.DataSource = lista;
                    gdvGeneros.DataMember = "Tabela";
                    gdvGeneros.DataBind();
                }
            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Genero objGenero = new Genero();
            objGenero.inserir(txtGeneros.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Genero objGenero = new Genero();
            objGenero.alterar(txtGeneros.Text, txtidGeneros.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnApagar_Click(object sender, EventArgs e)
        {
            Genero objGenero = new Genero();
            objGenero.apagar(txtidGeneros.Text, txtGeneros.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void gdvGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvGeneros.SelectedRow;
            txtidGeneros.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtGeneros.Text = Server.HtmlDecode(row.Cells[2].Text);
        }
    }
}