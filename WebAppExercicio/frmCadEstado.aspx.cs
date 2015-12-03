﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebAppExercicio
{
    public partial class frmCadEstado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            CadEstado objCadEstado = new CadEstado();
            objCadEstado.inserir( txtEstado.Text, txtSigla.Text);
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            CadEstado objCadEstado = new CadEstado();
            objCadEstado.alterar(txtEstado.Text, txtSigla.Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void btnApagar_Click(object sender, EventArgs e)
        {
            CadEstado objCadEstado = new CadEstado();
            objCadEstado.apagar(txtEstado.Text, txtSigla.Text);
            Response.Redirect(Request.RawUrl);
        }
    }
}