﻿using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExercicio
{
    public partial class reNoticias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            carregarTabelaDataSet();
        }

        private void carregarTabelaDataSet()
        {
            CadNoticia objListarTodosFilmes = new CadNoticia();
            DataSet dtListarTodosFilmes = objListarTodosFilmes.dtListarTodasNoticias();

            for (int linha = 0; linha <= dtListarTodosFilmes.Tables["Tabela"].Rows.Count - 1; linha++)
            {
                TableRow tRow = new TableRow();
                tabelaNoticias.Rows.Add(tRow);

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