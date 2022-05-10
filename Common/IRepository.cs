using System;
using System.Collections.Immutable;

namespace Common
{
    public interface IRepository<T>
    {
        T ObterPorID(Guid? id);
        ImmutableHashSet<T> ObterTodos();
        void Gravar(T obj);
        void Remover(T obj);
    }
}
