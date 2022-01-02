using Dio_Series.Interface;
using Dio_Series.Model;
using System.Collections.Generic;
using System.Linq;

namespace Dio_Series.Repositorio
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> serieList = new List<Serie>()
        {
            new Serie(1,Model.Enums.Genero.Acao,"Uma familia da pesada","Serie de ação da familia da pesada",2003),
            new Serie(2,Model.Enums.Genero.Aventura,"Hora da Aventura","Serie de aventura da hora da aventura", 2005),
            new Serie(3, Model.Enums.Genero.Musical,"High School Musical","Serie de musical da Disnel", 2008),
            new Serie(4,Model.Enums.Genero.Drama,"Dramalhaço","Uma dramalhaço de oh",2010)
        };
        public void Atualizar(Serie entidade)
        {
          Serie serie =  serieList.Where(x => x.Id == entidade.Id).FirstOrDefault();
          
                serieList.Remove(serie);
                serieList.Add(entidade);

            
                
        }

        public void Excluir(int id)
        {
            serieList.RemoveAt(id);
        }

        public void Inserir(Serie entidade)
        {
            serieList.Add(entidade);
        }

        public List<Serie> Listar() => serieList;
        

        public int ProximoId()
        {
           return serieList.Count;
        }

        public Serie RetornaId(int id)
        {
             return serieList.Where(c=> c.Id == id).FirstOrDefault();
        }
    }
}
