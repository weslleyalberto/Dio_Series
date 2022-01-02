using Dio_Series.Model.Enums;
using System;

namespace Dio_Series.Model
{
    public  class Serie : Entities
    {
        //atributos
        public Genero Genero { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public int Ano { get; private set; }

        public Serie(int id,Genero genero, string titulo, string descricao, int ano)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Titulo: " + Titulo + Environment.NewLine;
            retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + Ano + Environment.NewLine;
            return retorno;
        }
        public String RetornaTitulo() => Titulo;
       
        public int RetornaId() => Id;
       
    }
}
