using Common;
using Domain.Models.Venda;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Repositories.Repositories
{
    public class VendaRepository : IRepository<Venda>
    {
        private HashSet<Venda> _repository = new HashSet<Venda>();
        public int codigoProduto { get; private set; }

        public VendaRepository()
        {
            codigoProduto = 0;
        }
        public Venda ObterPorCodigo(int codigo)
        {
            return _repository.Where(p => p.Codigo == codigo).FirstOrDefault();
        }
        public Venda ObterPorID(Guid? id)
        {
            return _repository.Where(p => p.ProdutoID.Equals(id)).FirstOrDefault();
        }
        public ImmutableHashSet<Venda> ObterTodos()
        {
            return _repository.ToImmutableHashSet();
        }
        public void Gravar(Venda obj)
        {
            obj.Codigo = codigoProduto;
            codigoProduto++;

            _repository.Add(obj);
        }
        public void Remover(Venda obj)
        {
            _repository.Remove(obj);
        }

        ImmutableHashSet<Venda> IRepository<Venda>.ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}