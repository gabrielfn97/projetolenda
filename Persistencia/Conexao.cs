using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Biblioteca de conexão com SQLServer

namespace Persistencia
{
    class Conexao
    {
        SqlConnection cn = new SqlConnection();
        
        //Construtor da Classe
        public Conexao(String banco)
        {
               cn.ConnectionString = "Data Source=localhost;" +
               "Integrated Security=SSPI;" +
               "Initial Catalog=BDLP2015";
               cn.Open();
        }

        //Não retorna nenhum tipo de dado, apenas o número de células afetadas
        public int executeNoQuery(String SQL){
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = SQL;
            return cmd.ExecuteNonQuery();
        }

        //Retorna um único valor (object) escalar
        public object executeScalar(String SQL)
        {
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = SQL;
            return cmd.ExecuteScalar();
        }

        //Retorna um objeto DataReader, com o resultado da consulta
        public SqlDataReader executeReader(String SQL)
        {
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = SQL;
            return cmd.ExecuteReader();
        }
        
        //Fecha a Conexao
        public void fechaConexao()
        {
            cn.Close();
        }
    }
}
