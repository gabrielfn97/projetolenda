using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class ListarTodosFilmes
    {
        public DataSet dtListarTodosFilmes()
        {
            pListarTodosFilmes objListarTodosFilmes = new pListarTodosFilmes();
            return objListarTodosFilmes.dtListarTodosfilmes();
        }

    }
}
