using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProdutos
{
    class Produto
    {
        private string _nome;
        private string _categoria;
        private string _peso;
        private string _dataFabricacao;
        private string _dataValidade;
        private string _fornecedor;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public string Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        public string DataFabricacao
        {
            get { return _dataFabricacao; }
            set { _dataFabricacao = value; }
        }

        public string DataValidade
        {
            get { return _dataValidade; }
            set { _dataValidade = value; }
        }

        public string Fornecedor
        {
            get { return _fornecedor; }
            set { _fornecedor = value; }
        }
    }
}
