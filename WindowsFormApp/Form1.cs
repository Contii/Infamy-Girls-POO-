using Domain.Models.CadastroCliente;
using Domain.Models.CadastroProduto;
using Domain.Models.Venda;
using Persistence.DAL;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Form1 : Form
    {
        //private ClienteDAL _clienteDal = new ClienteDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
        //private EnderecoDAL _enderecoDal = new EnderecoDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
        //private MedidaDAL _medidaDal = new MedidaDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));

        //private CategoriaDAL _categoriaDal = new CategoriaDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
        //private ProdutoDAL _produtoDal = new ProdutoDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));

        //private VendaDAL _vendaDal = new VendaDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
        //private ItemVendaDAL _itemVendaDal = new ItemVendaDAL(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
        private bool _carregandoGridView = true;
        public Form1()
        {

            InitializeComponent();
            Button_Inserir.Enabled = false;
            Button_Alterar.Enabled = false;
            Button_Pesquisar.Enabled = false;
            Button_Excluir.Enabled = false;

            Button_Clientes.Enabled = true;
            Button_Produtos.Enabled = true;
            Button_Vendas.Enabled = true;
            DgvForm1.DataSource = null;
        }

        private void Button_Clientes_Click(object sender, EventArgs e)
        {
            Button_Clientes.Enabled = true;
            Button_Produtos.Enabled = false;
            Button_Vendas.Enabled = false;

            Button_Inserir.Enabled = true;
            Button_Alterar.Enabled = true;
            Button_Pesquisar.Enabled = true;
            Button_Excluir.Enabled = true;

            ClienteDAL _clienteDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));

            //Obtertodos
            DgvForm1.DataSource = null;
            DgvForm1.DataSource = _clienteDal.ObterTodos();
            DgvForm1.Columns[0].Visible = false;
            DgvForm1.ClearSelection();
            _carregandoGridView = false;

        }
        private void Button_Vendas_Click_1(object sender, EventArgs e)
        {
            Button_Clientes.Enabled = false;
            Button_Produtos.Enabled = false;
            Button_Vendas.Enabled = true;

            Button_Inserir.Enabled = true;
            Button_Alterar.Enabled = true;
            Button_Pesquisar.Enabled = true;
            Button_Excluir.Enabled = true;

            ClienteDAL _vendaDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
            //Obtertodos
            DgvForm1.DataSource = null;
            DgvForm1.DataSource = _vendaDal.ObterTodos();
            DgvForm1.Columns[0].Visible = false;
            DgvForm1.ClearSelection();
            _carregandoGridView = false;

        }
        private void Button_Produtos_Click_1(object sender, EventArgs e)
        {
            Button_Clientes.Enabled = false;
            Button_Produtos.Enabled = true;
            Button_Vendas.Enabled = false;

            Button_Inserir.Enabled = true;
            Button_Alterar.Enabled = true;
            Button_Pesquisar.Enabled = true;
            Button_Excluir.Enabled = true;

            ProdutoDAL _produtoDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
            //Obtertodos
            DgvForm1.DataSource = null;
            DgvForm1.DataSource = _produtoDal.ObterTodos();
            DgvForm1.Columns[0].Visible = false;
            DgvForm1.ClearSelection();
            _carregandoGridView = false;

        }



        private void Button_Inserir_Click_1(object sender, EventArgs e)
        {

            if (Button_Clientes.Enabled == true)
            {
                FormInserirCliente insereCliente = new();
                insereCliente.Show();
            }
            if (Button_Produtos.Enabled == true)
            {
                InserirProduto insereProduto = new();
                insereProduto.Show();
            }
            if (Button_Vendas.Enabled == true)
            {
                FormInserirVenda insereVenda = new();//bloquear inserir com selected row
                insereVenda.Show();
            }
            Button_Inserir.Enabled = false;
            Button_Alterar.Enabled = false;
            Button_Pesquisar.Enabled = false;
            Button_Excluir.Enabled = false;

            Button_Clientes.Enabled = true;
            Button_Produtos.Enabled = true;
            Button_Vendas.Enabled = true;
            DgvForm1.DataSource = null;
        }
        private void Button_Alterar_Click(object sender, EventArgs e)// verificar selecao datagrid para chamar form com id
        {
            if (Button_Clientes.Enabled == true)
                {
                FormInserirCliente insereCliente = new();
                insereCliente.Show();
                }
            if (Button_Produtos.Enabled == true)
                {
                InserirProduto insereProduto = new();
                insereProduto.Show();
                }
            if (Button_Vendas.Enabled == true)
                {
                    MessageBox.Show("Não é possivel alterar Vendas.");
                }
            Button_Inserir.Enabled = false;
            Button_Alterar.Enabled = false;
            Button_Pesquisar.Enabled = false;
            Button_Excluir.Enabled = false;

            Button_Clientes.Enabled = true;
            Button_Produtos.Enabled = true;
            Button_Vendas.Enabled = true;
            DgvForm1.DataSource = null;
        }


        private void Button_Excluir_Click(object sender, EventArgs e)
        {
            if (Button_Clientes.Enabled == true)
            {
                //Exclusão Medida
                MedidaDAL _medidaDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));

                var medidaID = DgvForm1.SelectedRows[6].Index.ToString();
                _medidaDal.Remover(Guid.Parse(medidaID));


                //Exclusão Endereco
                EnderecoDAL _enderecoDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));

                var enderecoID = DgvForm1.SelectedRows[5].Index.ToString();
                _enderecoDal.Remover(Guid.Parse(enderecoID));


                //Exclusão Cliente
                ClienteDAL _clienteDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));

                var clienteID = DgvForm1.SelectedRows[0].Index.ToString();
                _clienteDal.Remover(Guid.Parse(clienteID));
            }
            if (Button_Produtos.Enabled == true)
            {
                //Exclusão Produto
                ProdutoDAL _produtoDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));

                var produtoID = DgvForm1.SelectedRows[0].Index.ToString();
                _produtoDal.RemoverSuperiorInferior(Guid.Parse(produtoID));
            }
            if (Button_Vendas.Enabled == true)
            {
                ItemVendaDAL _itemVendaDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
                VendaDAL _VendaDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));

                //var itemVendaID = DgvForm1.SelectedRows[0].Index.ToString();
                var vendaID = DgvForm1.SelectedRows[3].Index.ToString();

                //Exclusão ItemVenda
                _itemVendaDal.RemoverItens(Guid.Parse(vendaID));

                //Exclusão Venda
                _VendaDal.Remover(Guid.Parse(vendaID));
            }
            MessageBox.Show("Excluido com sucesso", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Button_Inserir.Enabled = false;
            Button_Alterar.Enabled = false;
            Button_Pesquisar.Enabled = false;
            Button_Excluir.Enabled = false;

            Button_Clientes.Enabled = true;
            Button_Produtos.Enabled = true;
            Button_Vendas.Enabled = true;
            DgvForm1.DataSource = null;
        }
        private void Button_Pesquisar_Click(object sender, EventArgs e)// limpar datagrid para popular datagrid de acordo
        {
            if (Button_Clientes.Enabled == true)
            {
                //Pesquisa Cliente
                ClienteDAL _clienteDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));

                var cliente = TxtPesquisa.Text;

                //ObterNomes
                DgvForm1.DataSource = null;
                DgvForm1.DataSource = _clienteDal.ObterPorNome(cliente);
                DgvForm1.Columns[0].Visible = false;
                DgvForm1.ClearSelection();
                _carregandoGridView = false;
            }
            if (Button_Produtos.Enabled == true)
            {
                //Pesquisa Produto
                ProdutoDAL _produtoDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));

                var produto = TxtPesquisa.Text;

                //ObterNomes
                DgvForm1.DataSource = null;
                DgvForm1.DataSource = _produtoDal.ObterPorNome(produto);
                DgvForm1.Columns[0].Visible = false;
                DgvForm1.ClearSelection();
                _carregandoGridView = false;
            }
            if (Button_Vendas.Enabled == true)
            {
                //Pesquisa Venda
                VendaDAL _vendaDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));

                var clienteID = DgvForm1.SelectedRows[0].Index.ToString();
                _vendaDal.ObterPorClienteID(Guid.Parse(clienteID));
            }
        }

        private void Button_Voltar_Click(object sender, EventArgs e)
        {
            Button_Inserir.Enabled = false;
            Button_Alterar.Enabled = false;
            Button_Pesquisar.Enabled = false;
            Button_Excluir.Enabled = false;

            Button_Clientes.Enabled = true;
            Button_Produtos.Enabled = true;
            Button_Vendas.Enabled = true;
            DgvForm1.DataSource = null;
        }

        private void DgvForm1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(!_carregandoGridView)
            {
                var codigo = DgvForm1.Rows[e.RowIndex].Cells[0].Value;
            }
        }
    }
}
