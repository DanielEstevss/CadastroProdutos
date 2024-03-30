using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroProdutos
{
    public partial class Form1 : Form
    {
        // Criando a list que irá armazenar os produtos cadastrados
        List<Produto> produtos;
        public Form1()
        {
            // Inicializando list
            produtos = new List<Produto>();

            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos estão preenchidos
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo Nome");
                txtNome.Focus();
                return;
            }

            if (txtPeso.Text == "")
            {
                MessageBox.Show("Preencha o campo Peso");
                txtPeso.Focus();
                return;
            }

            if (txtDataFabricacao.Text == "  /  /")
            {
                MessageBox.Show("Preencha o campo Data de Fabricação");
                txtDataFabricacao.Focus();
                return;
            }

            if (txtDataValidade.Text == "  /  /")
            {
                MessageBox.Show("Preencha o campo Data de Validade");
                txtDataValidade.Focus();
                return;
            }

            if (txtFornecedor.Text == "")
            {
                MessageBox.Show("Preencha o campo Fornecedor");
                txtFornecedor.Focus();
                return;
            }

            // Verifica qual categoria foi selecionada
            string CategoriaSelecionada;

            if (radioAlimentosNaoPereciveis.Checked)
            {
                CategoriaSelecionada = "Alimento não perecível";
            }

            else if (radioAlimentosPereciveis.Checked)
            {
                CategoriaSelecionada = "Alimento perecível";
            }

            else if (radioBebidas.Checked)
            {
                CategoriaSelecionada = "Bebida";
            }

            else if (radioProdutosLimpeza.Checked)
            {
                CategoriaSelecionada = "Limpeza";
            }

            else if (radioHigiene.Checked)
            {
                CategoriaSelecionada = "Higiene pessoal";
            }

            else
            {
                CategoriaSelecionada = "Mercearia";
            }

            Teste teste = new Teste();

            string connectionString = teste.ConnectionString;


            // Cria um objeto do tipo Produto
            Produto produto = new Produto();

            produto.Nome = txtNome.Text;
            produto.Categoria = CategoriaSelecionada;
            produto.Peso = txtPeso.Text;
            produto.DataFabricacao = txtDataFabricacao.Text;
            produto.DataValidade = txtDataValidade.Text;
            produto.Fornecedor = txtFornecedor.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Produto (Nome, Categoria, Peso, DataFabricacao, DataValidade, Fornecedor) " +
                               "VALUES (@Nome, @Categoria, @Peso, @DataFabricacao, @DataValidade, @Fornecedor)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Adicionando parâmetros
                    command.Parameters.AddWithValue("@Nome", produto.Nome);
                    command.Parameters.AddWithValue("@Categoria", produto.Categoria);
                    command.Parameters.AddWithValue("@Peso", produto.Peso);
                    command.Parameters.AddWithValue("@DataFabricacao", produto.DataFabricacao);
                    command.Parameters.AddWithValue("@DataValidade", produto.DataValidade);
                    command.Parameters.AddWithValue("@Fornecedor", produto.Fornecedor);

                    // Executar a inserção
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pessoa inserida com sucesso no banco de dados.");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao inserir Pessoa no banco de dados"); ;
                    }
                }
            }

            // Adiciona o produto cadastrado na list
            produtos.Add(produto);

            // Limpa os campos após o cadastro do produto
            LimparCampos();

            // Exibe o nome do produto cadastrado
            Listar();
        }

        // Método para limpar os campos
        private void LimparCampos()
        {
            txtNome.Text = "";
            radioAlimentosNaoPereciveis.Checked = true;
            radioAlimentosPereciveis.Checked = false;
            radioBebidas.Checked = false;
            radioProdutosLimpeza.Checked = false;
            radioHigiene.Checked = false;
            radioMercearia.Checked = false;
            txtPeso.Text = "";
            txtDataFabricacao.Text = "";
            txtDataValidade.Text = "";
            txtFornecedor.Text = "";

            txtNome.Focus();
        }

        // Método para exibir o nome dos produtos cadastrados
        private void Listar()
        {
            lista.Items.Clear();

            foreach (Produto p in produtos)
            {
                lista.Items.Add($"Produto: {p.Nome}");
            }
        }
    }


}
