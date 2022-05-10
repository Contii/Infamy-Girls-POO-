using Domain.Models.Venda;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence.DAL
{
    public class VendaDAL
    {
        private SqlConnection _sqlConnection;
        public VendaDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir(Venda venda)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "insert into TB_Venda(VendaID, ClienteID) " +
                "values(@vendaID, @clienteID)";
            command.Parameters.AddWithValue("@vendaID", Guid.NewGuid());
            command.Parameters.AddWithValue("@clienteID", venda.ClienteID);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public IReadOnlyCollection<Venda> ObterTodos()
        {
            List<Venda> vendas = new();
            var command = new SqlCommand(
                "select VendaID, ClienteID from TB_Venda order by ClienteID", _sqlConnection);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var venda = new Venda(reader.GetGuid(0), reader.GetGuid(1));
                }
            }
            _sqlConnection.Close();
            return vendas.AsReadOnly();
        }
        public Venda ObterPorID(Guid? vendaID)
        {
            Venda venda = null;
            var command = new SqlCommand("select VendaID, ClienteID from TB_Venda" +
                "where VendaID = @vendaID", _sqlConnection);
            command.Parameters.AddWithValue("@vendaID", vendaID);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    venda = new Venda(reader.GetGuid(0), reader.GetGuid(1));
                }
            }
            _sqlConnection.Close();
            return venda;
        }
        public Venda ObterPorClienteID(Guid? clienteID)
        {
            Venda venda = null;
            var command = new SqlCommand("select VendaID, ClienteID from TB_Venda" +
                "where ClienteID = @clienteID", _sqlConnection);
            command.Parameters.AddWithValue("@clienteID", clienteID);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    venda = new Venda(reader.GetGuid(0), reader.GetGuid(1));
                }
            }
            _sqlConnection.Close();
            return venda;
        }
        public void Gravar(Venda venda)
        {
            if (venda.VendaID == null)
            {
                Inserir(venda);
            }
            else
            {
                Atualizar(venda);
            }
        }
        public void Remover(Guid vendaID)
        {
            var command = new SqlCommand("delete from TB_Venda " +
                    "where VendaID = @vendaID", _sqlConnection);
            command.Parameters.AddWithValue("@vendaID", vendaID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        private void Atualizar(Venda venda)
        {
            var command = new SqlCommand("update TB_Venda " +
                  "set VendaID = @vendaID, ClienteID = @clienteID" +
                  "where VendaID = @vendaID", _sqlConnection);
            command.Parameters.AddWithValue("@vendaID", venda.VendaID);
            command.Parameters.AddWithValue("@clienteID", venda.ClienteID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}