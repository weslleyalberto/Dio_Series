using Dio_Series.Model;
using System.Collections.Generic;

namespace Dio_Series.Interface
{
    public interface IRepositorio<T> where T: Entities
    {
        List<T> Listar();
        T RetornaId(int id);

        void Inserir(T entidade);
        void Excluir(int id);
        void Atualizar(T entidade);
        int ProximoId();
    }
}
