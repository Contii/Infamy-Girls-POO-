using Domain.Models.CadastroCliente;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistence.DAL
{
    public class MedidaDAL
    {
        private SqlConnection _sqlConnection;
        public MedidaDAL(SqlConnection sqlConnection)
        {
            _sqlConnection = sqlConnection;
        }
        public void Inserir(Medida medida)
        {
            _sqlConnection.Open();
            SqlCommand command = _sqlConnection.CreateCommand();
            command.CommandText = "insert into TB_Medida(MedidaID, MedidaBusto, MedidaSubBusto, MedidaCintura) " +
                "values(@medidaID, @medidaBusto, @medidaSubBusto, @medidaCintura)";
            command.Parameters.AddWithValue("@medidaID", medida.MedidaID);
            command.Parameters.AddWithValue("@medidaBusto", medida.MedidaBusto);
            command.Parameters.AddWithValue("@medidaSubBusto", medida.MedidaSubBusto);
            command.Parameters.AddWithValue("@medidaCintura", medida.MedidaCintura);
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
        public IReadOnlyCollection<Medida> ObterTodos()
        {
            List<Medida> medidas = new();
            var command = new SqlCommand(
                "select MedidaID, MedidaBusto, MedidaSubBusto, MeididaCalcinha from TB_Medida order by MedidaID", _sqlConnection);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var medida = new Medida(reader.GetDecimal(1), reader.GetDecimal(2), reader.GetDecimal(3), reader.GetGuid(0));
                    medidas.Add(medida);
                }
            }
            _sqlConnection.Close();
            return medidas.AsReadOnly();
        }
        public Medida ObterPorID(Guid? medidaID)
        {
            Medida medida = null;
            var command = new SqlCommand("select MedidaID, MedidaBusto, MedidaSubBusto, MedidaCintura from TB_Medida" +
                "where MedidaID = @medidaID", _sqlConnection);
            command.Parameters.AddWithValue("@medidaID", medidaID);
            _sqlConnection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    medida = new Medida(reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetGuid(0));
                }
            }
            _sqlConnection.Close();
            return medida;
        }
        public void Gravar(Medida medida)
        {
            Inserir(medida);
            //if (medida.MedidaID == null)
            //{
            //    Inserir(medida);
            //}
            //else
            //{
            //    Atualizar(medida);
            //}
        }
        public void Remover(Guid medidaID)
        {
            var command = new SqlCommand("delete from TB_Medida " +
                    "where MedidaID = @medidaID", _sqlConnection);
            command.Parameters.AddWithValue("@medidaID", medidaID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        private void Atualizar(Medida medida)
        {
            var command = new SqlCommand("update TB_Medida " +
                  "set MedidaBusto = @medidaBusto, MedidaSubBusto = @medidaSubBusto, MedidaCintura = @medidaCintura where MedidaID = @medidaID", _sqlConnection);
            command.Parameters.AddWithValue("@medidaBusto", medida.MedidaBusto);
            command.Parameters.AddWithValue("@medidaSubBusto", medida.MedidaSubBusto);
            command.Parameters.AddWithValue("@medidaCintura", medida.MedidaCintura);
            command.Parameters.AddWithValue("@medidaID", medida.MedidaID);
            _sqlConnection.Open();
            command.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}