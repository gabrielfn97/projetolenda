
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

        public void votacao(String idLogin, String idFilme, int nota)
        {
            pVotacaoFilme objtp = new pVotacaoFilme();
            objtp.inserir(idLogin, idFilme, nota);
        }

        

        

    }
}
