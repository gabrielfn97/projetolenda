﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Negocio
{
    public class Categoria
    {
        String descricao;
        int idClassificacao;

        public void inserir(String descricao, String idClassificacao)
        {
            pCategoria objCategoria = new pCategoria();
            objCategoria.inserir(descricao, idClassificacao);
        }

        public void alterar(String descricao, int idClassificacao)
        {
            pCategoria objCategoria = new pCategoria();
            objCategoria.alterar(descricao, idClassificacao);
        }

        public void apagar(String descricao, int idClassificacao)
        {
            pCategoria objCategoria = new pCategoria();
            objCategoria.apagar(descricao, idClassificacao);
        }

        public DataSet consultarTodos()
        {
            pCategoria objCategoria = new pCategoria();
            return objCategoria.consultarTodos();
        }


    }
}
