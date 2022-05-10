using Domain.Models.CadastroCliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence.DAL
{
    public class ClienteDAL
    {
        private SqlConnection _sqlConnection;
        public ClienteDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir(Cliente cliente)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "insert into TB_Cliente(ClienteID, Nome, Cpf, Rg, DataNascimento, EnderecoID, MedidaID) " +
                "values(@clienteID, @nome, @cpf, @rg, @dataNascimento, @enderecoID, @medidaID)";
            command.Parameters.AddWithValue("@clienteID", Guid.NewGuid());
            command.Parameters.AddWithValue("@nome", cliente.Nome);
            command.Parameters.AddWithValue("@cpf", cliente.Cpf); 
            command.Parameters.AddWithValue("@rg", cliente.Rg);
            command.Parameters.AddWithValue("@dataNascimento", cliente.DataNascimento);
            command.Parameters.AddWithValue("@enderecoID", cliente.EnderecoID);
            command.Parameters.AddWithValue("@medidaID", cliente.MedidaID);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public IReadOnlyCollection<Cliente> ObterTodos()
        {
            List<Cliente> clientes = new();
            var command = new SqlCommand(
                "select ClienteID, Nome, Rg, Cpf, DataNascimento, EnderecoID, MedidaID from TB_Cliente order by Nome", _sqlConnection);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var cliente = new Cliente(reader.GetString(1), reader.GetString(3), reader.GetString(2),
                        reader.GetString(4), reader.GetGuid(5), reader.GetGuid(6), reader.GetGuid(0));
                    clientes.Add(cliente);
                }
            }
            _sqlConnection.Close();
            return clientes.AsReadOnly();
        }
        public Cliente ObterPorID(Guid? clienteID)
        {
            Cliente cliente = null;
            var command = new SqlCommand("select ClienteID, Nome, Cpf, Rg, DataNascimento from TB_Cliente" +
                "where ClienteID = @clienteID", _sqlConnection);
            command.Parameters.AddWithValue("@clienteID", clienteID);
            _sqlConnection.Open();
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    cliente = new Cliente(reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetString(4), reader.GetGuid(0), reader.GetGuid(5), reader.GetGuid(6));
                }
            }
            _sqlConnection.Close();
            return cliente;
        }
        public Cliente ObterPorNome(string nome)
        {
            Cliente cliente = null;
            var command = new SqlCommand("select ClienteID, Nome, Cpf, Rg, DataNascimento from TB_Cliente" +
                "where Nome = @nome", _sqlConnection);
            command.Parameters.AddWithValue("@nome", nome);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    cliente = new Cliente(reader.GetString(1), reader.GetString(2), reader.GetString(3),
                        reader.GetString(4), reader.GetGuid(0), reader.GetGuid(5), reader.GetGuid(6));
                }
            }
            _sqlConnection.Close();
            return cliente;
        }
        public void Gravar(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome))
            {
                throw new Exception("Nome não pode ser em branco");
            }
            if (cliente.ClienteID == null)
            {
                Inserir(cliente);
            } else
            {
                Atualizar(cliente);
            }
        }
        public void Remover(Guid clienteID)
        {
            var command = new SqlCommand("delete from TB_Cliente " +
                    "where ClienteID = @clienteID", _sqlConnection);
            command.Parameters.AddWithValue("@clienteID", clienteID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        private void Atualizar (Cliente cliente)
        {
            var command = new SqlCommand("update TB_Cliente " +
                  "set Nome = @nome, Cpf = @cpf, Rg = @rg, DataNascimento = @dataNascimento, EnderecoID = @enderecoID, MedidaID = @medidaID where ClienteID = @clienteID", _sqlConnection);
            command.Parameters.AddWithValue("@nome", cliente.Nome);
            command.Parameters.AddWithValue("@cpf", cliente.Cpf);
            command.Parameters.AddWithValue("@rg", cliente.Rg);
            command.Parameters.AddWithValue("@dataNascimento", cliente.DataNascimento);
            command.Parameters.AddWithValue("@enderecoID", cliente.EnderecoID);
            command.Parameters.AddWithValue("@medidaID", cliente.MedidaID);
            command.Parameters.AddWithValue("@clienteID", cliente.ClienteID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

    }
}
