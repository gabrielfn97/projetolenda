using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
     public class CadCidade
    {
        String cidade;
        String fkEstado;

        public void inserir(String fkEstado, String cidade)
        {
            pCadCidade objCadCidade = new pCadCidade();
            objCadCidade.inserir(fkEstado, cidade);
        }

        public void alterar(String fkEstado, String cidade, String idCadCidade)
        {
            pCadCidade objCadCidade = new pCadCidade();
            objCadCidade.alterar(fkEstado, cidade, idCadCidade);
        }

        public void apagar(String idCadCidade, String cidade)
        {
            pCadCidade objCadCidade = new pCadCidade();
            objCadCidade.apagar(idCadCidade, cidade);
        }

        public DataSet consultarTodos()
        {
            pCadCidade objCadCidade = new pCadCidade();
            return objCadCidade.consultarTodos();
        }

    }
}
