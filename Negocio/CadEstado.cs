using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class CadEstado
    {
        
        String estado;
        String sigla;

        public void inserir( String estado, String sigla)
        {
            pCadEstado objCadEstado = new pCadEstado();
            objCadEstado.inserir(estado,sigla);
        }

        public void alterar(String estado, String sigla)
        {
            pCadEstado objCadEstado = new pCadEstado();
            objCadEstado.alterar(estado, sigla);
        }

        public void apagar(String idCadEstado,String estado, String sigla)
        {
            pCadEstado objCadEstado = new pCadEstado();
            objCadEstado.apagar(idCadEstado, estado, sigla);
        }

        public DataSet consultarTodos()
        {
            pCadEstado objCadEstado = new pCadEstado();
            return objCadEstado.consultarTodos();
        }

    }
}
