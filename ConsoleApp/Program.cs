using Domain.Models.CadastroCliente;
using Domain.Models.CadastroProduto;
using Domain.Models.Venda;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace ConsoleApp
{
    class Program
    {
        public static object Cliente { get; private set; }

        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["InfamyGirls_DBConn"].ConnectionString;
            ClienteRepository repositorioCliente = new ClienteRepository();
            ProdutoRepository repositorioProduto= new ProdutoRepository();


            int opcao;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1 - cadastrar cliente");
                Console.WriteLine("2 - cadastrar produto");
                Console.WriteLine("3 - cadastrar venda");
                Console.WriteLine("4 - visualizar cliente");
                Console.WriteLine("5 - visualizar produto");
                Console.WriteLine("6 - visualizar venda");
                Console.WriteLine("7 - sair");
                Console.Write("Escolha uma opcao: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1:
                        CadastrarCliente();
                        break;

                    case 2:
                        CadastrarProduto();
                        break;

                    case 3:
                        CadastrarVenda();
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;
                }

            } while (opcao != 7);

            void CadastrarCliente()
            {
                string nome;
                DateTime dataNascimento;
                string rg;
                string cpf;
                string estado;
                string cidade;
                string bairro;
                string rua;
                string numero;
                string cep;
                decimal medidaBusto;
                decimal medidaSuBusto;
                decimal medidaCintura;

                Console.Write("Informe o nome: ");
                nome = Console.ReadLine();

                Console.Write("Informe a data de nascimento: ");
                DateTime.TryParse(Console.ReadLine(), out dataNascimento);

                Console.Write("Informe o rg: ");
                rg = Console.ReadLine();

                Console.Write("Informe o cpf: ");
                cpf = Console.ReadLine();

                Console.Write("Informe o estado: ");
                estado = Console.ReadLine();

                Console.Write("Informe o cidade: ");
                cidade = Console.ReadLine();

                Console.Write("Informe o bairro: ");
                bairro = Console.ReadLine();

                Console.Write("Informe o rua: ");
                rua = Console.ReadLine();

                Console.Write("Informe o numero: ");
                numero = Console.ReadLine();

                Console.Write("Informe o cep: ");
                cep = Console.ReadLine();

                Console.Write("Informe a medida do busto: ");
                medidaBusto = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Informe a medida do sub-busto: ");
                medidaSuBusto = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Informe a medida da cintura: ");
                medidaCintura = Convert.ToDecimal(Console.ReadLine());

                try
                {
                    Endereco endereco = new(estado, cidade, bairro, rua, numero, cep);
                    Medida medida = new(medidaBusto, medidaSuBusto, medidaCintura);
                    Cliente cliente = new(nome, cpf, rg, dataNascimento, endereco.EnderecoID, medida.MedidaID);

                    repositorioCliente.Gravar(cliente);
                    Console.Write("Cadastro realizado com sucesso");

                } catch (Exception error)
                {
                    Console.Write(error.Message);
                }
            }

            void CadastrarProduto(){
                string nome;
                decimal valor;
                string tamanho;
                int tipo;

                Console.Write("Informe o nome: ");
                nome = Console.ReadLine();

                Console.Write("Informe o valor: ");
                valor = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Informe o tamanho: ");
                tamanho = Console.ReadLine();

                while (true)
                {
                    Console.Write("Escolha o tipo (1 - superior | 2 - inferior | 3 superior e inferior): ");
                    tipo = Convert.ToInt32(Console.ReadLine());
                    if (tipo == 1 || tipo == 2 || tipo == 3) break;
                }

                try
                {
                    Produto produto = null;
                    decimal medidaCinturaMin;
                    decimal medidaCinturaMax;
                    decimal medidaBustoMin;
                    decimal medidaBustoMax;
                    decimal medidaSubBustoMin;
                    decimal medidaSubBustoMax;
                    string categoria;
                    int categoriaProduto;

                    switch (tipo)
                    {
                        case 1:
                            CriarPecaSuperior();
                            break;

                        case 2:
                            CriarPecaInferior();
                            break;

                        case 3:
                            CriarPecaSuperiorInferior();
                            break;
                    }

                    void CriarPecaSuperior()
                    {
                        Console.Write("Informe medidaBustoMin: ");
                        medidaBustoMin = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Informe medidaBustoMax: ");
                        medidaBustoMax = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Informe medidaSubBustoMin: ");
                        medidaSubBustoMin = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Informe medidaSubBustoMax: ");
                        medidaSubBustoMax = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("1 - Sutia");
                        Console.WriteLine("2 - Cropped");
                        Console.WriteLine("3 - TomaraQueCaia");
                        Console.Write("Escolha uma categoria: ");
                        while (true)
                        {
                            categoriaProduto = Convert.ToInt32(Console.ReadLine());
                            if (categoriaProduto == 1 || categoriaProduto == 2 || categoriaProduto == 3) break;
                            Console.WriteLine("Valor não aceito");
                        }
                        

                        if (categoriaProduto == 1)
                            categoria = CategoriaENUM.Sutia;

                        if (categoriaProduto == 2)
                            categoria = CategoriaENUM.Cropped;

                        if (categoriaProduto == 3)
                            categoria = CategoriaENUM.TomaraQueCaia;

                        produto = new PecaSuperior(nome, valor, tamanho, categoria,
                            medidaBustoMin, medidaBustoMax, medidaBustoMin, medidaSubBustoMax);
                    }

                    void CriarPecaInferior()
                    {
                        Console.Write("Informe medidaCinturaMin: ");
                        medidaCinturaMin = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Informe medidaCinturaMax: ");
                        medidaCinturaMax = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("1 - Calcinha");
                        Console.WriteLine("2 - Calecon");
                        Console.Write("Escolha uma categoria: ");
                        
                        categoriaProduto = Convert.ToInt32(Console.ReadLine());

                        if (categoriaProduto == 1)
                            categoria = CategoriaENUM.Calcinha;

                        if (categoriaProduto == 2)
                            categoria = CategoriaENUM.Calecon;

                        produto = new PecaInferior(nome, valor, tamanho, categoria,
                            medidaCinturaMin, medidaCinturaMax);
                    }

                    void CriarPecaSuperiorInferior()
                    {
                        Console.Write("Informe medidaBustoMin: ");
                        medidaBustoMin = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Informe medidaBustoMax: ");
                        medidaBustoMax = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Informe medidaSubBustoMin: ");
                        medidaSubBustoMin = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Informe medidaSubBustoMax: ");
                        medidaSubBustoMax = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Informe medidaCinturaMin: ");
                        medidaCinturaMin = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Informe medidaCinturaMax: ");
                        medidaCinturaMax = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("1 - Conjunto");
                        Console.WriteLine("2 - Camisola");
                        Console.WriteLine("3 - Body");
                        Console.WriteLine("4 - Biquini");
                        Console.Write("Escolha uma categoria: ");
                        while (true)
                        {
                            categoriaProduto = Convert.ToInt32(Console.ReadLine());
                            if (categoriaProduto == 1 || categoriaProduto == 2 || categoriaProduto == 3 || categoriaProduto == 4) break;
                            Console.WriteLine("Valor não aceito");
                        }

                        if (categoriaProduto == 1)
                            categoria = CategoriaENUM.Conjunto;

                        if (categoriaProduto == 2)
                            categoria = CategoriaENUM.Camisola;

                        if (categoriaProduto == 3)
                            categoria = CategoriaENUM.Body;

                        if (categoriaProduto == 4)
                            categoria = CategoriaENUM.Biquini;

                        produto = new PecaSuperiorInferior(nome, valor, tamanho, categoria,
                            medidaBustoMin, medidaBustoMax, medidaSubBustoMin, medidaSubBustoMax,
                            medidaCinturaMin, medidaCinturaMax);
                    }

                    repositorioProduto.Gravar(produto);
                    Console.Write("Produto cadastrado com sucesso");
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }

            void CadastrarVenda()
            {
                string cpf;
                int codigo;
                Cliente cliente;
                Produto produto;
                ItemVenda itemVenda;
                List<ItemVenda>  listaItens = new List<ItemVenda>();
                Venda venda;

                Console.WriteLine("Informe o cpf do cliente:");
                cpf = Console.ReadLine();

                Console.WriteLine("Informe o codigo do produto");
                codigo = Convert.ToInt32(Console.ReadLine());

                cliente = repositorioCliente.ObterPorCPF(cpf);
                produto = repositorioProduto.ObterPorCodigo(codigo);

                itemVenda = new(produto, 3);
                listaItens.Add(itemVenda);

                venda = new Venda(cliente, listaItens);
            }
        }
    }
}