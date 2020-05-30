using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    class Produto {

        // ATRIBUTOS
        private string _nome;
        private double _preco;
        private int _quantidade;

        //CONSTRUTOR PADRAO
        public Produto() { 
        }

        //CONSTRUTOR
        //Obriga informar um nome, preço e quantidade.
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;

        }

        //Implementando Método Get e Set

        //Implementando Método Get para obter o nome do produto
        public string GetNome() {
            return _nome;
        }

        //Implementando Método Set para alterar o nome do produto
        public void SetNome(string nome) {

  //se o nome for diferente de vazio e a quantidade de letras for maior que 1
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
             
        }

        public double GetPreco() {
            return _preco;
        }

        public int GetQuantidade() { 
        return _quantidade;
        }

        //MÉTODOS
        public double ValorTotalEmEstoque() {

            return _preco * _quantidade;

        }

        //void=vazio, a funão não irá retornar nenhum valor
        public void AdicionarProdutos(int quantidade) {

            _quantidade = _quantidade + quantidade;
            //OU
            // Quantidade += quantidade;


        }

        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }



        //Sobreposição
        public override string ToString() {
            return _nome
                + ", $ " + string.Format("{0:n2}", _preco)
                + ", "
                + _quantidade + " unidades, Total: $ "
                + string.Format("{0:n2}", ValorTotalEmEstoque());
        }

    }
}