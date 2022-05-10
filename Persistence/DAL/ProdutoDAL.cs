using Domain.Models.CadastroProduto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence.DAL
{
    public class ProdutoDAL
    {
        private SqlConnection _sqlConnection;
        public ProdutoDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }

        #region Superior
        public void InserirSuperior(PecaSuperior produto)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "insert into TB_Produto(ProdutoID, Nome, Valor ,Categoria ,Tamanho ,Cor, MedidaBustoMax, MedidaBustoMin, MedidaSubBustoMax, MedidaSubBustoMin) " +
                "values(@produtoID, @nome, @valor, @categoria, @tamanho, @cor, @medidaBustoMax, @medidaBustoMin, @medidaSubBustoMax, @medidaSubBustoMin)";
            command.Parameters.AddWithValue("@produtoID", Guid.NewGuid());
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@valor", produto.Valor);
            command.Parameters.AddWithValue("@categoria", produto.Categoria);
            command.Parameters.AddWithValue("@tamanho", produto.Tamanho);
            command.Parameters.AddWithValue("@cor", produto.Cor);
            command.Parameters.AddWithValue("@medidaBustoMax", produto.MedidaBustoMax);
            command.Parameters.AddWithValue("@medidaBustoMin", produto.MedidaBustoMin);
            command.Parameters.AddWithValue("@medidaSubBustoMax", produto.MedidaSubBustoMax);
            command.Parameters.AddWithValue("@medidaSubBustoMin", produto.MedidaSubBustoMin);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public void GravarSuperior(PecaSuperior produto)
        {
            if (produto.ProdutoID == null)
            {
                InserirSuperior(produto);
            }
            else
            {
                AtualizarSuperior(produto);
            }
        }
        private void AtualizarSuperior(PecaSuperior produto)
        {
            var command = new SqlCommand("update TB_Produto " +
                  "set Nome = @nome, Valor = @valor, Categoria = @categoria, Tamanho = @tamanho, Cor = @cor," +
                  "MedidaBustoMax = @medidaBustoMax, MedidaBustoMin = @medidaBustoMin," +
                  "MedidaSubBustoMax = @medidaSubBustoMax, MedidaSubBustoMin = @medidaSubBustoMin," +
                  "where ProdutoID = @produtoID", _sqlConnection);
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@valor", produto.Valor);
            command.Parameters.AddWithValue("@categoria", produto.Categoria);
            command.Parameters.AddWithValue("@tamanho", produto.Tamanho);
            command.Parameters.AddWithValue("@cor", produto.Cor);
            command.Parameters.AddWithValue("@medidaBustoMax", produto.MedidaBustoMax);
            command.Parameters.AddWithValue("@medidaBustoMin", produto.MedidaBustoMin);
            command.Parameters.AddWithValue("@medidaSubBustoMax", produto.MedidaSubBustoMax);
            command.Parameters.AddWithValue("@medidaSubBustoMin", produto.MedidaSubBustoMin);
            command.Parameters.AddWithValue("@produtoID", produto.ProdutoID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        #endregion

        #region Inferior
        public void InserirInferior(PecaInferior produto)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "insert into TB_Produto(ProdutoID, Nome, Valor ,Categoria ,Tamanho ,Cor, MedidaCinturaMax, MedidaCinturaMin) " +
                "values(@produtoID, @nome, @valor, @categoria, @tamanho, @cor, @medidaCinturaMax, @medidaCinturaMin)";
            command.Parameters.AddWithValue("@produtoID", Guid.NewGuid());
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@valor", produto.Valor);
            command.Parameters.AddWithValue("@categoria", produto.Categoria);
            command.Parameters.AddWithValue("@tamanho", produto.Tamanho);
            command.Parameters.AddWithValue("@cor", produto.Cor);
            command.Parameters.AddWithValue("@cmedidaCinturaMaxor", produto.MedidaCinturaMax);
            command.Parameters.AddWithValue("@medidaCinturaMin", produto.MedidaCinturaMin);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public void GravarInferior(PecaInferior produto)
        {
            if (produto.ProdutoID == null)
            {
                InserirInferior(produto);
            }
            else
            {
                AtualizarInferior(produto);
            }
        }
        private void AtualizarInferior(PecaInferior produto)
        {
            var command = new SqlCommand("update TB_Produto " +
                  "set Nome = @nome, Valor = @valor, Categoria = @categoria, Tamanho = @tamanho, Cor = @cor," +
                  "MedidaCinturaMax = @medidaCinturaoMax, MedidaCinturaMin = @medidaCinturaMin," +
                  "where ProdutoID = @produtoID", _sqlConnection);
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@valor", produto.Valor);
            command.Parameters.AddWithValue("@categoria", produto.Categoria);
            command.Parameters.AddWithValue("@tamanho", produto.Tamanho);
            command.Parameters.AddWithValue("@cor", produto.Cor);
            command.Parameters.AddWithValue("@medidaCinturaMax", produto.MedidaCinturaMax);
            command.Parameters.AddWithValue("@medidaCinturaMin", produto.MedidaCinturaMin);
            command.Parameters.AddWithValue("@produtoID", produto.ProdutoID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        #endregion

        #region SuperiorInferior
        public void InserirSuperiorInferior(PecaSuperiorInferior produto)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "insert into TB_Produto(ProdutoID, Nome, Valor ,Categoria ,Tamanho ,Cor, MedidaBustoMax, MedidaBustoMin, MedidaSubBustoMax, MedidaSubBustoMin, MedidaCinturaMax, MedidaCinturaMin) " +
                "values(@produtoID, @nome, @valor, @categoria, @tamanho, @cor, @medidaBustoMax, @medidaBustoMin, @medidaSubBustoMax, @medidaSubBustoMin, @medidaCinturaMax, @medidaCinturaMin)";
            command.Parameters.AddWithValue("@produtoID", Guid.NewGuid());
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@valor", produto.Valor);
            command.Parameters.AddWithValue("@categoria", produto.Categoria);
            command.Parameters.AddWithValue("@tamanho", produto.Tamanho);
            command.Parameters.AddWithValue("@cor", produto.Cor);
            command.Parameters.AddWithValue("@medidaBustoMax", produto.MedidaBustoMax);
            command.Parameters.AddWithValue("@medidaBustoMin", produto.MedidaBustoMin);
            command.Parameters.AddWithValue("@medidaSubBustoMax", produto.MedidaSubBustoMax);
            command.Parameters.AddWithValue("@medidaSubBustoMin", produto.MedidaSubBustoMin);
            command.Parameters.AddWithValue("@medidaCinturaMax", produto.MedidaCinturaMax);
            command.Parameters.AddWithValue("@medidaCinturaMin", produto.MedidaCinturaMin);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public void GravarSuperiorInferior(PecaSuperiorInferior produto)
        {
            if (produto.ProdutoID == null)
            {
                InserirSuperiorInferior(produto);
            }
            else
            {
                AtualizarSuperiorInferior(produto);
            }
        }
        private void AtualizarSuperiorInferior(PecaSuperiorInferior produto)
        {
            var command = new SqlCommand("update TB_Produto " +
                  "set Nome = @nome, Valor = @valor, Categoria = @categoria, Tamanho = @tamanho, Cor = @cor," +
                  "MedidaBustoMax = @medidaBustoMax, MedidaBustoMin = @medidaBustoMin," +
                  "MedidaSubBustoMax = @medidaSubBustoMax, MedidaSubBustoMin = @medidaSubBustoMin," +
                  "where ProdutoID = @produtoID", _sqlConnection);
            command.Parameters.AddWithValue("@nome", produto.Nome);
            command.Parameters.AddWithValue("@valor", produto.Valor);
            command.Parameters.AddWithValue("@categoria", produto.Categoria);
            command.Parameters.AddWithValue("@tamanho", produto.Tamanho);
            command.Parameters.AddWithValue("@cor", produto.Cor);
            command.Parameters.AddWithValue("@medidaBustoMax", produto.MedidaBustoMax);
            command.Parameters.AddWithValue("@medidaBustoMin", produto.MedidaBustoMin);
            command.Parameters.AddWithValue("@medidaSubBustoMax", produto.MedidaSubBustoMax);
            command.Parameters.AddWithValue("@medidaSubBustoMin", produto.MedidaSubBustoMin);
            command.Parameters.AddWithValue("@medidaCinturaMax", produto.MedidaCinturaMax);
            command.Parameters.AddWithValue("@medidaCinturaMin", produto.MedidaCinturaMin);

            command.Parameters.AddWithValue("@produtoID", produto.ProdutoID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        #endregion

        public IReadOnlyCollection<PecaSuperiorInferior> ObterTodos()
        {
            List<PecaSuperiorInferior> produtos = new();
            var command = new SqlCommand(
                "select ProdutoID, Nome , Valor, Categoria, Tamanho, Cor, MedidaBustoMax, MedidaBustoMin, MedidaSubBustoMax, MedidaSubBustoMin, MedidaCinturaMax, MedidaCinturaMin from TB_Produto order by Categoria", _sqlConnection);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var produto = new PecaSuperiorInferior(reader.GetString(0), reader.GetDecimal(1), reader.GetGuid(2),
                        reader.GetString(3), reader.GetString(4),  reader.GetDecimal(5), reader.GetDecimal(6), reader.GetDecimal(7), reader.GetDecimal(8)
                        , reader.GetDecimal(9), reader.GetDecimal(10), reader.GetGuid(11));
                }
            }
            _sqlConnection.Close();
            return produtos.AsReadOnly();
        }
        public PecaSuperiorInferior ObterPorID(Guid? produtoID)
        {
            PecaSuperiorInferior produto = null;
            var command = new SqlCommand("select ProdutoID, Nome, Valor, Tamanho, Cor, Categoria from TB_Produto" +
                "where ProdutoID = @produtoID", _sqlConnection);
            command.Parameters.AddWithValue("@produtoID", produtoID);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    produto = new PecaSuperiorInferior(reader.GetString(0), reader.GetDecimal(1), reader.GetGuid(2),
                        reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetDecimal(6), reader.GetDecimal(7), reader.GetDecimal(8)
                        , reader.GetDecimal(9), reader.GetDecimal(10), reader.GetGuid(11));
                }
            }
            _sqlConnection.Close();
            return produto;
        }
        public PecaSuperiorInferior ObterPorNome(string nome)
        {
            PecaSuperiorInferior produto = null;
            var command = new SqlCommand("select ProdutoID, Nome, Valor, Tamanho, Cor, Categoria from TB_Produto" +
                "where Nome = @nome", _sqlConnection);
            command.Parameters.AddWithValue("@nome", nome);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    produto = new PecaSuperiorInferior(reader.GetString(0), reader.GetDecimal(1), reader.GetGuid(2),
                        reader.GetString(3), reader.GetString(4), reader.GetDecimal(5), reader.GetDecimal(6), reader.GetDecimal(7), reader.GetDecimal(8)
                        , reader.GetDecimal(9), reader.GetDecimal(10), reader.GetGuid(11));
                }
            }
            _sqlConnection.Close();
            return produto;
        }
        public void RemoverSuperiorInferior(Guid produtoID)
        {
            var command = new SqlCommand("delete from TB_Produto " +
                    "where ProdutoID = @produtoID", _sqlConnection);
            command.Parameters.AddWithValue("@produtoID", produtoID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}