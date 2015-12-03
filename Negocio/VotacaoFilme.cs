
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

        public void alterar(String idLogin, String idFilme, String qtdEstrela)
        {
            pVotacaoFilme objVotacaoFilme = new pVotacaoFilme();
            objVotacaoFilme.alterar(idLogin, idFilme, qtdEstrela);
        }

        public void apagar(String idLogin, String idFilme, String qtdEstrela)
        {
            pVotacaoFilme objVotacaoFilme = new pVotacaoFilme();
            objVotacaoFilme.apagar(idLogin, idFilme, qtdEstrela);
        }

        public Object consultarTodos()
        {
            pVotacaoFilme objVotacaoFilme = new pVotacaoFilme();
            return objVotacaoFilme.consultarTodos();
        }

    }
}
