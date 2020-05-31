using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Properties {
    class Produto {

        // ATRIBUTOS PRIVADOS
        private string _nome;
        private double _preco;
        private int _quantidade;

        //CONSTRUTOR PADRAO
        public Produto() {
        }

        //CONSTRUTOR
        //método utiizando os atributos privados 
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;

        }

        //Aula 56 Properties
        //Caso não queiroa utilizar Get e Set
        //Criamos uma Properties utilizando as operações Get e Set

        public string Nome {

            get { return _nome; }

            set {
                if (value != null && value.Length > 1)
                    _nome = value;
            }

        }

        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }
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