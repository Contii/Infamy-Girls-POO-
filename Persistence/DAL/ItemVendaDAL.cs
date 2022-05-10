using Domain.Models.Venda;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Persistence.DAL
{
    public class ItemVendaDAL
    {
        private SqlConnection _sqlConnection;
        public ItemVendaDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir(ItemVenda itemVenda)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "insert into TB_ItemVenda(ItemVendaID, Quantidade, ProdutoID, VendaID) " +
                "values(@itemVendaID, @quantidade, @produtoID, @vendaID)";
            command.Parameters.AddWithValue("@itemVendaID", Guid.NewGuid());
            command.Parameters.AddWithValue("@quantidade", itemVenda.Quantidade);
            command.Parameters.AddWithValue("@produtoID", itemVenda.ProdutoID);
            command.Parameters.AddWithValue("@vendaID", itemVenda.VendaID);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public IReadOnlyCollection<ItemVenda> ObterTodos()
        {
            List<ItemVenda> itemVendas = new();
            var command = new SqlCommand(
                "select ItemVendaID, Quantidade, ProdutoID, VendaID from TB_ItemVenda order by ItemVendaID", _sqlConnection);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var itemVenda = new ItemVenda(reader.GetInt32(0), reader.GetGuid(1), reader.GetGuid(2), reader.GetGuid(3));
                }
            }
            _sqlConnection.Close();
            return itemVendas.AsReadOnly();
        }
        public ItemVenda ObterPorID(Guid? itemVendaID)
        {
            ItemVenda itemVenda = null;
            var command = new SqlCommand("select ItemVendaID, Quantidade, ProdutoID, VendaID from TB_ItemVenda" +
                "where ItemVendaID = @itemVendaID", _sqlConnection);
            command.Parameters.AddWithValue("@itemVendaID", itemVendaID);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    itemVenda = new ItemVenda(reader.GetInt32(0), reader.GetGuid(1), reader.GetGuid(2));
                }
            }
            _sqlConnection.Close();
            return itemVenda;
        }
        public void Gravar(ItemVenda itemVenda)
        {
            if (itemVenda.ItemVendaID == null)
            {
                Inserir(itemVenda);
            }
            else
            {
                Atualizar(itemVenda);
            }
        }
        public void Remover(ItemVenda itemVenda)
        {
            var command = new SqlCommand("delete from TB_ItemVenda " +
                    "where ItemVendaID = @itemVendaID", _sqlConnection);
            command.Parameters.AddWithValue("@itemVendaID", itemVenda.ItemVendaID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public void RemoverItens(Guid vendaID)
        {
            var command = new SqlCommand("delete from TB_ItemVenda " +
            "where VendaID = @vendaID", _sqlConnection);
            command.Parameters.AddWithValue("@vendaID", vendaID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        private void Atualizar(ItemVenda itemVenda)
        {
            var command = new SqlCommand("update TB_itemVenda " +
                  "set ItemVendaID = @itemVendaID, Quantidade = @quantidade, ProdutoID = @produtoID, VendaID = @vendaID" +
                  "where ItemVendaID = @itemVendaID", _sqlConnection);
            command.Parameters.AddWithValue("@itemVendaID", itemVenda.ItemVendaID);
            command.Parameters.AddWithValue("@quantidade", itemVenda.Quantidade);
            command.Parameters.AddWithValue("@produtoID", itemVenda.ProdutoID);
            command.Parameters.AddWithValue("@vendaID", itemVenda.VendaID);

            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}