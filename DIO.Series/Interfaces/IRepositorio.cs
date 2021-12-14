using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
	interface IRepositorio<T>
	{
        List<T> Lista();
        T RetornaItem(int id);
        void Adiciona(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}
