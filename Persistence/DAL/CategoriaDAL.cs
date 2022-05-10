using Domain.Models.CadastroProduto;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DAL
{
    public class CategoriaDAL
    {
        private SqlConnection _sqlConnection;
        public CategoriaDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir(Categoria categoria)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "insert into TB_Categoria(CategoriaID, Nome) " +
                "values(@categoriaID, @nome)";
            command.Parameters.AddWithValue("@categoriaID", Guid.NewGuid());
            command.Parameters.AddWithValue("@nome", categoria.Nome);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public IReadOnlyCollection<Categoria> ObterTodos()
        {
            List<Categoria> categorias = new List<Categoria>();
            var command = new SqlCommand(
                "select CategoriaID, Nome from TB_Categoria order by Nome", _sqlConnection);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var categoria = new Categoria(reader.GetString(0), reader.GetGuid(1));
                }
            }
            _sqlConnection.Close();
            return categorias.AsReadOnly();
        }
        public Categoria ObterPorID(Guid? categoriaID)
        {
            Categoria categoria = null;
            var command = new SqlCommand("select CategoriaID, Nome from TB_Categoria" +
                "where CategoriaID = @categoriaID", _sqlConnection);
            command.Parameters.AddWithValue("@categoriaID", categoria.CategoriaID);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    categoria = new Categoria(reader.GetString(0), reader.GetGuid(1));
                }
            }
            _sqlConnection.Close();
            return categoria;
        }
        public void Gravar(Categoria categoria)
        {
            if (categoria.CategoriaID == null)
            {
                Inserir(categoria);
            }
            else
            {
                Atualizar(categoria);
            }
        }
        public void Remover(Categoria categoria)
        {
            var command = new SqlCommand("delete from TB_Categoria " +
                    "where CategoriaID = @categoriaID", _sqlConnection);
            command.Parameters.AddWithValue("@categoriaID", categoria.CategoriaID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        private void Atualizar(Categoria categoria)
        {
            var command = new SqlCommand("update TB_Categoria " +
                  "set CategoriaID = @categoriaID, Nome = @nome" +
                  "where CategoriaID = @categoriaID", _sqlConnection);
            command.Parameters.AddWithValue("@categoriaID", categoria.CategoriaID);
            command.Parameters.AddWithValue("@nome", categoria.Nome);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}