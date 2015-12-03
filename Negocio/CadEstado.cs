using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

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

        public void apagar(String estado, String sigla)
        {
            pCadEstado objCadEstado = new pCadEstado();
            objCadEstado.apagar(estado, sigla);
        }

        public Object consultarTodos()
        {
            pCadEstado objCadEstado = new pCadEstado();
            return objCadEstado.consultarTodos();
        }

       

       

    }
}
