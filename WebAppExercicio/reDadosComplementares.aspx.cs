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
    public partial class reDadosComplementares : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            carregarTabelaDataSet();
        }

        private void carregarTabelaDataSet()
        {
            DadosComplementares objListarTodosDados = new DadosComplementares();
            DataSet dtListarTodosFilmes = objListarTodosDados.consultarTodos();

            for (int linha = 0; linha <= dtListarTodosFilmes.Tables["Tabela"].Rows.Count - 1; linha++)
            {
                TableRow tRow = new TableRow();
                tblDados.Rows.Add(tRow);

                for (int coluna = 0; coluna <= 7; coluna++)
                {
                    TableCell tCell = new TableCell();
                    tCell.Text = Convert.ToString(dtListarTodosFilmes.Tables["Tabela"].Rows[linha][coluna]);
                    tRow.Cells.Add(tCell);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("fmrFormularios.aspx");
        }
    }
}