﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pCadEstado
    {
        String idCadEstado;
        String estado;
        String sigla;

        public void inserir( String estado, String sigla)
        {
            String SQL = "INSERT INTO dbo.CadEstado( estado, sigla) VALUES('" + estado + "','" + sigla + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }


        public void alterar(String estado, String sigla, String idCadEstado)
        {
            String SQL = "UPDATE dbo.CadEstado";
            SQL += " SET estado = '" + estado + "', sigla = '" + sigla + "'";
            SQL += " WHERE idCadEstado = " + idCadEstado;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();

        }

        public void apagar(String idCadEstado, String estado, String sigla)
        {
            String SQL = "DELETE dbo.CadEstado WHERE idCadEstado = " + idCadEstado;

            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public DataSet consultarTodos()
        {
            String SQL = "SELECT idCadEstado as ID, estado as Estado, sigla as Sigla FROM dbo.CadEstado";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }


    }
}
