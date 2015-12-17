using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExercicio
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                lblValor.Text = (String)Session["Usuario"] + " xxx";
            }
            else
            {
                Response.Redirect("frmLogin.aspx");
            }
        }
    }
}