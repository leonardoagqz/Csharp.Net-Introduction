using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Sobrecarga {
    class Produto {

        // ATRIBUTOS
        public string Nome;
        public double Preco;
        public int Quantidade;


        //CONTRUTOR PADRÃO
        //Para que seja permitido utiliza-lo no programa principal
        public Produto() { 
        
        }

        //CONSTRUTOR 3 arqumentos
        //Obriga informar um nome, preço e quantidade.
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        //CONSTRUTOR 2 argumentos
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;/*Por padrão os atributos numericos já recebem o valor 0, por tando 
                             não é obrigatório informar Quantidade = 0, porém é importante saber 
                             que eu posso informar Quantidade = 10 por exemplo.  */
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