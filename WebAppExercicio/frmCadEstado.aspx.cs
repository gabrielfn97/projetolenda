﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;


namespace WebAppExercicio
{
    public partial class frmCadEstado : System.Web.UI.Page
    {
        DataSet lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CadEstado oCadEstado = new CadEstado();
                lista = oCadEstado.consultarTodos();

                if (lista != null)
                {
                    gdvCadEstado.DataSource = lista;
                    gdvCadEstado.DataMember = "Tabela";
                    gdvCadEstado.DataBind();
                }
            }
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            CadEstado objCadEstado = new CadEstado();
            objCadEstado.inserir( txtEstado.Text, txtSigla.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            CadEstado objCadEstado = new CadEstado();
            objCadEstado.alterar(txtEstado.Text, txtSigla.Text, txtidCadEstado.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnApagar_Click(object sender, EventArgs e)
        {
            CadEstado objCadEstado = new CadEstado();
            objCadEstado.apagar(txtidCadEstado.Text,txtEstado.Text,txtSigla.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void gdvCadEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gdvCadEstado.SelectedRow;

            txtidCadEstado.Text = Server.HtmlDecode(row.Cells[1].Text);
            txtEstado.Text = Server.HtmlDecode(row.Cells[2].Text);
            txtSigla.Text = Server.HtmlDecode(row.Cells[3].Text);
        }

      
    }
}