using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Sobrecarga {
    class Produto {
                
        public string Nome;
        public double Preco;
        public int Quantidade;

        //CONTRUTOR PADRÃO
               
        public Produto() {
            Quantidade = 10;  
        }

        //CONSTRUTOR 2 argumentos
         public Produto(string nome, double preco) {
             Nome = nome;
             Preco = preco;
             Quantidade = 0;/*Por padrão os atributos numericos já recebem o valor 0, por tando 
                              não é obrigatório informar Quantidade = 0, porém é importante saber 
                              que eu posso informar Quantidade = 10 por exemplo. */
         }


        //CONSTRUTOR 2 argumentos
        //Palavra this Reaproveitando Quantidade=0 do construtor padrão
        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
        }
        
        //CONSTRUTOR 3 argumentos
        //Palavra this Reaproveitando nome e preco do construtor padrão
        public Produto(string nome, double preco, int quantidade) : this(nome,preco) {
            Quantidade = quantidade;
        }


        //Passar o proprio objeto como argumnto na chamada de um método ou construtor
        //Proxima aula



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
