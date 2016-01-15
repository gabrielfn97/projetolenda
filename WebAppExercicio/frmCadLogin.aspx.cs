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
    public partial class frmCadLogin : System.Web.UI.Page
    {
        DataSet lista;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Usuarios oCadLogin = new Usuarios();
                lista = oCadLogin.consultarTodos();

                if (lista != null)
                {
                    gdvCadLogin.DataSource = lista;
                    gdvCadLogin.DataMember = "Tabela";
                    gdvCadLogin.DataBind();
                }
            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Usuarios objCadLogin = new Usuarios();
            objCadLogin.inserir(txtEmail.Text, txtUsuario.Text, txtSenha.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            Usuarios objCadLogin = new Usuarios();
            objCadLogin.alterar(txtEmail.Text, txtUsuario.Text, txtSenha.Text, txtidCadLogin.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnApagar_Click(object sender, EventArgs e)
        {

            Usuarios objCadLogin = new Usuarios();
            objCadLogin.apagar(txtEmail.Text, txtUsuario.Text, txtSenha.Text, txtidCadLogin.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void gdvCadLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvCadLogin.SelectedRow;
            txtidCadLogin.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtEmail.Text = Server.HtmlDecode(row.Cells[2].Text);
            txtUsuario.Text = Server.HtmlDecode(row.Cells[3].Text);
            txtSenha.Text = Server.HtmlDecode(row.Cells[4].Text);
        }
    }
}