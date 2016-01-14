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
    public partial class frmRelatorioFilmes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            carregarTabelaDataSet();
        }

        private void carregarTabelaTeste()
        {
            int rowCnt, rowCtr, cellCnt, cellCtr;

            rowCnt = 2;
            cellCnt = 3;

            for (rowCtr = 1; rowCtr <= rowCnt; rowCtr++)
            {
                TableRow tRow = new TableRow();
                tabelaFilmes.Rows.Add(tRow);

                for (cellCtr = 1; cellCtr <= cellCnt; cellCtr++)
                {
                    TableCell tCell = new TableCell();
                    tCell.Text = "Linha" + rowCtr + ", Coluna" + cellCtr;
                    tRow.Cells.Add(tCell);
                }
            }
        }

        private void carregarTabelaDataSet()
        {
            ListarTodosFilmes objListarTodosFilmes = new ListarTodosFilmes();
            DataSet dtListarTodosFilmes = objListarTodosFilmes.dtListarTodosFilmes();

            for (int linha = 0; linha <= dtListarTodosFilmes.Tables["Tabela"].Rows.Count - 1; linha++)
            {
                TableRow tRow = new TableRow();
                tabelaFilmes.Rows.Add(tRow);

                for (int coluna = 0; coluna <= 3; coluna++)
                {
                    TableCell tCell = new TableCell();
                    tCell.Text = Convert.ToString(dtListarTodosFilmes.Tables["Tabela"].Rows[linha][coluna]);
                    tRow.Cells.Add(tCell);
                }
            }
        }
    }
}