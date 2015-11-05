using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pLogin
    {
        String login;
        String senha;

        public void inserir(String login, String senha)
        {
            String SQL = "INSERT INTO Pessoas(login, senha) VALUES(" + login + ",'" + senha + "')";
            Conexao oConexao = new Conexao("SQLServer");
            oConexao.executeNoQuery(SQL);
            oConexao.fechaConexao();
        }

        public void alterar()
        {

        }

        public void apagar()
        {

        }

        public Object consultarTodos()
        {
            return 1;
        }

    }
}
