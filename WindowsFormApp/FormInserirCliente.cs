using Domain.Models.CadastroCliente;
using Persistence.DAL;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class FormInserirCliente : Form
    {
        public FormInserirCliente()
        {
            InitializeComponent();

        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            //Inserir Endereco
            EnderecoDAL _enderecoDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
            Endereco endereco = new(TxtEstado.Text.ToString(), TxtCidade.Text.ToString(),
                TxtBairro.Text.ToString(), TxtRua.Text.ToString(), TxtNumero.Text.ToString(), TxtCep.Text.ToString(), Guid.NewGuid());
            try
            {
                _enderecoDal.Gravar(endereco);
            }
            catch( Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Inserir Medida
            MedidaDAL _medidaDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
            Medida medida = new(Decimal.Parse(TxtBusto.Text), Decimal.Parse(TxtSubBusto.Text), Decimal.Parse(TxtCintura.Text), Guid.NewGuid());
            try
            {
                _medidaDal.Gravar(medida);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Inserir Cliente
            ClienteDAL _clienteDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
            Cliente cliente = new(TxtNome.Text.ToString(), TxtCpf.Text.ToString(), TxtRg.Text.ToString(),
                TxtDataNasc.Text.ToString(), endereco.EnderecoID, medida.MedidaID);
           
            try
            {
                _clienteDal.Gravar(cliente);
                MessageBox.Show("Cliente cadastrado com sucesso","!", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
