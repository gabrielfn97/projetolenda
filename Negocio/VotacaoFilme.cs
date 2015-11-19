
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    
    public class VotacaoFilme
    {
        String idLogin;
        String idFilme;
        String qtdEstrela;

        public void inserir(String idLogin, String idFilme, String qtdEstrela)
        {
            pVotacaoFilme objVotacaoFilme = new pVotacaoFilme();
            objVotacaoFilme.inserir(idLogin, idFilme, qtdEstrela);
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
