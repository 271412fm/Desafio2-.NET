using System.Collections.Generic;

namespace DigitalInnovationOne.Series.Interfaces
{

    public interface iRepositorio<T>
    {
        List<T> Lista();
        T retornoPorId(int id);
        void Insere (T entidade);
        void Remove(int id);
        void AtualizaSerie(int id, T entidade);
        int PróximoId();
        
    }
}