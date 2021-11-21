using System.Collections.Generic;
namespace Series
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade, int i);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}