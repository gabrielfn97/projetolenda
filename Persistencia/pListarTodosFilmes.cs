using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pListarTodosFilmes
    {
        public DataSet dtListarTodosfilmes()
        {
            String SQL = "SELECT NomeFilmes, Classificacao, Genero, Nota, AtoresPrincipais, Nacionalidade FROM dbo.CadFilmes";

            Conexao oConexao = new Conexao("SQLServer");

            SqlDataAdapter adapter = new SqlDataAdapter(SQL, oConexao.cn);
            DataSet ds = new DataSet("Tabela");
            adapter.Fill(ds, "Tabela");

            oConexao.fechaConexao();

            return ds;
        }
        
    }
}
