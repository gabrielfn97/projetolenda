using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebAppExercicio
{
    public partial class frmcategoriasfilmes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Genero objGenero = new Genero();
            objGenero.inserir(txtGeneros.Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Genero objGenero = new Genero();
            objGenero.alterar(txtGeneros.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnApagar_Click(object sender, EventArgs e)
        {
            Genero objGenero = new Genero();
            objGenero.apagar(txtGeneros.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void gdvGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvGeneros.SelectedRow;
            txtGeneros.Text = Server.HtmlDecode(row.Cells[1].Text);

        }
    }
}