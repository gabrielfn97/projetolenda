﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;


namespace Negocio
{
    public class CadFilmes
    {
        String NomeFilmes;
        String Classificacao;
        String Genero;
        String Iframe;
        String UrlImg;
        String Nota;
        String DataLacamento;
        String AtoresPrincipais;
        String Nacionalidade;

        public void inserir(String NomeFilmes, String Classificacao, String Genero, String Iframe, String UrlImg, String Nota, String DataLacamento, String AtoresPrincipais, String Nacionalidade)
        {
            pCadFilmes objCadFilmes = new pCadFilmes();
            objCadFilmes.inserir(NomeFilmes, Classificacao, Genero, Iframe, UrlImg, Nota, DataLacamento, AtoresPrincipais, Nacionalidade);
        }

        public void alterar(String NomeFilmes, String Classificacao, String Genero, String Iframe, String UrlImg, String Nota, String DataLacamento, String AtoresPrincipais, String Nacionalidade)
        {
            pCadFilmes objCadFilmes = new pCadFilmes();
            objCadFilmes.alterar(NomeFilmes, Classificacao, Genero, Iframe, UrlImg, Nota, DataLacamento, AtoresPrincipais, Nacionalidade);
        }

        public void apagar(String NomeFilmes, String Classificacao, String Genero, String Iframe, String UrlImg, String Nota, String DataLacamento, String AtoresPrincipais, String Nacionalidade)
        {
            pCadFilmes objCadFilmes = new pCadFilmes();
            objCadFilmes.apagar(NomeFilmes, Classificacao, Genero, Iframe, UrlImg, Nota, DataLacamento, AtoresPrincipais, Nacionalidade);
        }

        public Object consultarTodos()
        {
            pCadFilmes objCadFilmes = new pCadFilmes();
            return objCadFilmes.consultarTodos();
        }


    }
}