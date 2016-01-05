using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class pVotacaoFilme
    {
        String idLogin;
        String idFilme;
        String qtdEstrela;

        public void inserir(String idLogin, String idFilme, int qtdEstrela)
        {
            String SQL = "INSERT INTO VotacaoFilme(idLogin, idFilme, qtdEstrela) VALUES(" + idLogin + ",'" + idFilme + "','" + qtdEstrela + "')";
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
