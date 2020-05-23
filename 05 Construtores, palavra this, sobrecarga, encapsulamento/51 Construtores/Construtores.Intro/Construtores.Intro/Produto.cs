using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Aula42 {
    class Produto {

        // ATRIBUTOS
        public string Nome;
        public double Preco;
        public int Quantidade;

        //CONSTRUTOR
        //Obriga informar um nome, preço e quantidade.
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        
        }

        //MÉTODOS
        public double ValorTotalEmEstoque() {

            return Preco * Quantidade;

        }

        //void=vazio, a funão não irá retornar nenhum valor
        public void AdicionarProdutos(int quantidade) {

            Quantidade = Quantidade + quantidade;
            //OU
            // Quantidade += quantidade;


        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }



        //Sobreposição
        public override string ToString() {
            return Nome
                + ", $ " + string.Format("{0:n2}", Preco)
                + ", "
                + Quantidade + " unidades, Total: $ "
                + string.Format("{0:n2}", ValorTotalEmEstoque());
        }

    }
}