using Common;
using Domain.Models.CadastroProduto;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Repositories.Repositories
{
    public class ProdutoRepository : IRepository<Produto>
    {
        private HashSet<Produto> _repository = new HashSet<Produto>();
        public int codigoProduto { get; private set; }

        public ProdutoRepository()
        {
            codigoProduto = 0;
        }
        public Produto ObterPorCodigo(int codigo)
        {
            return _repository.Where(p => p.Codigo == codigo).FirstOrDefault();
        }
        public Produto ObterPorID(Guid? id)
        {
            return _repository.Where(p => p.ProdutoID.Equals(id)).FirstOrDefault();
        }
        public ImmutableHashSet<Produto> ObterTodos()
        {
            return _repository.ToImmutableHashSet();
        }
        public void Gravar(Produto obj)
        {
            obj.Codigo = codigoProduto;
            codigoProduto ++;

            _repository.Add(obj);
        }
        public void Remover(Produto obj)
        {
            _repository.Remove(obj);
        }
    }
}