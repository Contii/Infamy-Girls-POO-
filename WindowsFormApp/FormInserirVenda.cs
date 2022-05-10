using Domain.Models.Venda;
using Persistence.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class FormInserirVenda : Form
    {
        ClienteDAL _clienteDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
        ItemVendaDAL _itemVendaDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
        ProdutoDAL _produtoDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
        VendaDAL _vendaDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
        private bool _carregandoGridView = true;
        private Guid clienteID = Guid.NewGuid();
        private Guid vendaID = Guid.NewGuid();
        private Guid produtoID = Guid.NewGuid();
        public FormInserirVenda()
        {
            InitializeComponent();
            //Obtertodos
            TxtCliente.Enabled = true;
            DgvVenda.DataSource = null;
            DgvVenda.DataSource = _clienteDal.ObterTodos();
            DgvVenda.Columns[0].Visible = false;
            DgvVenda.ClearSelection();
            _carregandoGridView = false;
            ButtonInserirItem.Enabled = false;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            TxtCliente.Enabled = true;
            DgvVenda.DataSource = null;
            DgvVenda.DataSource = _clienteDal.ObterTodos();
            DgvVenda.Columns[0].Visible = false;
            DgvVenda.ClearSelection();
            _carregandoGridView = false;
            ButtonInserirItem.Enabled = false;
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if (TxtCliente.Enabled == true)
            {

                //Obtertodos
                DgvVenda.DataSource = null;
                DgvVenda.DataSource = _clienteDal.ObterTodos();
                DgvVenda.Columns[0].Visible = false;
                DgvVenda.ClearSelection();
                _carregandoGridView = false;
            }
            if (TxtCliente.Enabled == false)
            {
                //Obtertodos
                DgvVenda.DataSource = null;
                DgvVenda.DataSource = _produtoDal.ObterTodos();
                DgvVenda.Columns[0].Visible = false;
                DgvVenda.ClearSelection();
                _carregandoGridView = false;

            }
        }

        private void ButtonInserirItem_Click(object sender, EventArgs e)
        {
            //Inserir Venda em itemVenda

            ItemVenda itemVenda = new(Convert.ToInt32(TxtQuantidade.Text), produtoID, vendaID);
            _itemVendaDal.Inserir(itemVenda);
        }

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void DgvVenda_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_carregandoGridView)
            {
                if(TxtCliente.Enabled == true)
                {
                    var cliente = DgvVenda.Rows[e.RowIndex].Cells[0].Value.ToString();
                    clienteID = Guid.Parse(cliente);
                    TxtCliente.Text = DgvVenda.Rows[e.RowIndex].Cells[1].Value.ToString();
                    Venda venda = new(clienteID, vendaID);
                    vendaID = Guid.NewGuid();
                    DgvVenda.DataSource = null;

                    DgvVenda.DataSource = null;
                    DgvVenda.DataSource = _produtoDal.ObterTodos();
                    DgvVenda.Columns[0].Visible = false;
                    DgvVenda.ClearSelection();
                    _carregandoGridView = false;
                    TxtCliente.Enabled = false;

                }
                if (TxtCliente.Enabled == false)
                {
                    var codigoProduto = DgvVenda.Rows[e.RowIndex].Cells[0].Value.ToString();
                    produtoID = Guid.Parse(codigoProduto);
                    TxtProduto.Text = DgvVenda.Rows[e.RowIndex].Cells[1].Value.ToString();
                    DgvVenda.DataSource = null;
                    ButtonInserirItem.Enabled = true;


                }
            }
        }
    }
}
