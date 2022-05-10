using Domain.Models.CadastroCliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence.DAL
{
    public class EnderecoDAL
    {
        private SqlConnection _sqlConnection;
        public EnderecoDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir(Endereco endereco)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "insert into TB_Endereco(EnderecoID, Estado, Cidade, Bairro, Rua, Numero, Cep) " +
                "values(@enderecoID, @estado, @cidade, @bairro, @rua, @numero, @cep)";
            command.Parameters.AddWithValue("@enderecoID", endereco.EnderecoID);
            command.Parameters.AddWithValue("@estado", endereco.Estado);
            command.Parameters.AddWithValue("@cidade", endereco.Cidade);
            command.Parameters.AddWithValue("@bairro", endereco.Bairro);
            command.Parameters.AddWithValue("@rua", endereco.Rua);
            command.Parameters.AddWithValue("@numero", endereco.Numero);
            command.Parameters.AddWithValue("@cep", endereco.Cep);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public IReadOnlyCollection<Endereco> ObterTodos()
        {
            List<Endereco> enderecos = new();
            var command = new SqlCommand(
                "select EnderecoID, Estado, Cidade, Bairro, Rua, Numero, Cep from TB_Endereco order by Estado", _sqlConnection);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var endereco = new Endereco(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetGuid(0));
                    enderecos.Add(endereco);
                }
            }
            _sqlConnection.Close();
            return enderecos.AsReadOnly();
        }
        public Endereco ObterPorID(Guid? enderecoID)
        {
            Endereco endereco = null;
            var command = new SqlCommand("select EnderecoID, Estado, Cidade, Bairro, Rua, Numero, Cep from TB_Endereco" +
                "where EnderecoID = @enderecoID", _sqlConnection);
            command.Parameters.AddWithValue("@enderecoID", enderecoID);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    endereco = new Endereco(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetGuid(0));
                }
            }
            _sqlConnection.Close();
            return endereco;
        }
        public void Gravar(Endereco endereco)
        {
            Inserir(endereco);
            //if (endereco.EnderecoID == null)
            //{
            //    Inserir(endereco);
            //}
            //else
            //{
            //    Atualizar(endereco);
            //}
        }
        public void Remover(Guid enderecoID)
        {
            var command = new SqlCommand("delete from TB_Endereco " +
                    "where EnderecoID = @enderecoID", _sqlConnection);
            command.Parameters.AddWithValue("@enderecoID", enderecoID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        private void Atualizar(Endereco endereco)
        {
            var command = new SqlCommand("update TB_Endereco " +
                  "set Estado = @estado, Cidade = @cidade, Bairro = @bairro, Rua = @rua, Numero = @numero, Cep = @cep where EnderecoID = @enderecoID", _sqlConnection);
            command.Parameters.AddWithValue("@estado", endereco.Estado);
            command.Parameters.AddWithValue("@cidade", endereco.Cidade);
            command.Parameters.AddWithValue("@bairro", endereco.Bairro);
            command.Parameters.AddWithValue("@rua", endereco.Rua);
            command.Parameters.AddWithValue("@numero", endereco.Numero);
            command.Parameters.AddWithValue("@cep", endereco.Cep);
            command.Parameters.AddWithValue("@enderecoID", endereco.EnderecoID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

    }
}