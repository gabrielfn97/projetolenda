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
