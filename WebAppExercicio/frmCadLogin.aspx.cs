﻿using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExercicio
{
    public partial class frmCadLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            CadLogin oCadLogin = new CadLogin();
            oCadLogin.inserir(txtEmail.Text, txtSenha.Text, txtUsuario.Text);
        }
    }
}