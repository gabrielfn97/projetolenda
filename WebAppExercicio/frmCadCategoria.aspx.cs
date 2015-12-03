using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Negocio;




namespace WebAppExercicio
{
    public partial class frmCadCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Categoria oCategoria = new Categoria();
            oCategoria.inserir(txtdescricao.Text, txtNdoFilme.Text);

        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Categoria oCategoria = new Categoria();
            oCategoria.alterar(txtdescricao.Text, txtNdoFilme.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnApagar_Click(object sender, EventArgs e)
        {
            Categoria oCategoria = new Categoria();
            oCategoria.apagar(txtdescricao.Text, txtNdoFilme.Text);
            Response.Redirect(Request.RawUrl);
        }

             
      

    }
}