using Dio_Series.Interface;
using Dio_Series.Model;
using Dio_Series.Repositorio;
using System;

namespace Dio_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepositorio<Serie> serie = new SerieRepositorio();
            serie.Inserir(new Serie(5, Model.Enums.Genero.Comedia, "Um maluco da pesada", "Um policial maluco é so comedia", 2005));
            serie.Atualizar(new Serie(1, Model.Enums.Genero.Acao, "Titulo mudado", "Descrição mudada", 2004));
           
            foreach(Serie s in serie.Listar())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(serie.RetornaId(serie.ProximoId()));
        }
    }
}
