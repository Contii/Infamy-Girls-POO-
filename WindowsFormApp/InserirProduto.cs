using Domain.Models.CadastroProduto;
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
    public partial class InserirProduto : Form
    {
        public InserirProduto()
        {
            InitializeComponent();
            if (RadioButtonSuperior.Checked == true)
            {
                RadioButtonInferior.Checked = false;
                RadioButtonSuperiorInferior.Checked = false;

                TxtBustoMax.Enabled = true;
                TxtBustoMin.Enabled = true;
                TxtSubBustoMax.Enabled = true;
                TxtSubBustoMin.Enabled = true;

                TxtCinturaMax.Enabled = false;
                TxtCinturaMax.Enabled = false;

                TxtCinturaMax.Text = "0";
                TxtCinturaMin.Text = "0";
            }
            if (RadioButtonInferior.Checked == true)
            {
                RadioButtonSuperior.Checked = false;
                RadioButtonSuperiorInferior.Checked = false;

                TxtBustoMax.Enabled = false;
                TxtBustoMin.Enabled = false;
                TxtSubBustoMax.Enabled = false;
                TxtSubBustoMin.Enabled = false;

                TxtCinturaMax.Enabled = true;
                TxtCinturaMax.Enabled = true;

                TxtBustoMax.Text = "0";
                TxtBustoMin.Text = "0";
                TxtSubBustoMax.Text = "0";
                TxtSubBustoMin.Text = "0";
            }
            if (RadioButtonSuperiorInferior.Checked == true)
            {
                RadioButtonInferior.Checked = false;
                RadioButtonSuperior.Checked = false;

                TxtBustoMax.Enabled = true;
                TxtBustoMin.Enabled = true;
                TxtSubBustoMax.Enabled = true;
                TxtSubBustoMin.Enabled = true;

                TxtCinturaMax.Enabled = true;
                TxtCinturaMax.Enabled = true;
            }
        }
        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            //Inserir Produto
            ProdutoDAL _produtoDal = new(new SqlConnection(ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString));
            if (RadioButtonSuperior.Checked == true)
            {
                PecaSuperior produto = new(TxtNome.Text, Decimal.Parse(TxtValor.Text), Guid.Parse(TxtCategoria.Text), TxtTamanho.Text, TxtCor.Text,
                    Decimal.Parse(TxtBustoMin.Text), Decimal.Parse(TxtBustoMax.Text), Decimal.Parse(TxtSubBustoMin.Text), Decimal.Parse(TxtSubBustoMax.Text));
                try
                {
                    _produtoDal.GravarSuperior(produto);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (RadioButtonInferior.Checked == true)
            {
                PecaInferior produto = new(TxtNome.Text, Decimal.Parse(TxtValor.Text), Guid.Parse(TxtCategoria.Text), TxtTamanho.Text, TxtCor.Text,
                    Decimal.Parse(TxtCinturaMin.Text), Decimal.Parse(TxtCinturaMax.Text));
                try
                {
                    _produtoDal.GravarInferior(produto);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (RadioButtonSuperiorInferior.Checked == true)
            {
                PecaSuperiorInferior produto = new(TxtNome.Text, Decimal.Parse(TxtValor.Text), Guid.Parse(TxtCategoria.Text), TxtTamanho.Text, TxtCor.Text,
                    Decimal.Parse(TxtBustoMin.Text), Decimal.Parse(TxtBustoMax.Text), Decimal.Parse(TxtSubBustoMin.Text), Decimal.Parse(TxtSubBustoMax.Text), Decimal.Parse(TxtCinturaMin.Text), Decimal.Parse(TxtCinturaMax.Text));
                try
                {
                    _produtoDal.GravarSuperiorInferior(produto);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}