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


        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.inserir(txtdescricao.Text, txtNdoFilme.Text);

        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.alterar(txtdescricao.Text, Convert.ToInt32(txtNdoFilme.Text));
            Response.Redirect(Request.RawUrl);
        }

        protected void btnApagar_Click(object sender, EventArgs e)
        {
            Categoria objCategoria = new Categoria();
            objCategoria.apagar(txtdescricao.Text, Convert.ToInt32(txtNdoFilme.Text));
            Response.Redirect(Request.RawUrl);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

             
      

    }
}