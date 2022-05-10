using Common;
using Domain.Models.CadastroCliente;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Repositories.Repositories
{
    public class ClienteRepository : IRepository<Cliente>
    {
        private HashSet<Cliente> _repository = new HashSet<Cliente>();
        public Cliente ObterPorID(Guid? id)
        {
            return _repository.Where(cliente => cliente.ClienteID.Equals(id)).FirstOrDefault();
        }
        public Cliente ObterPorCPF(string cpf)
        {
            return _repository.Where(cliente => cliente.Cpf == cpf).FirstOrDefault();
        }
        public ImmutableHashSet<Cliente> ObterTodos()
        {
            return _repository.ToImmutableHashSet();
        }
        public void Gravar(Cliente obj)
        {
            _repository.Add(obj);
        }
        public void Remover(Cliente obj)
        {
            _repository.Remove(obj);
        }
    }
}