using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace AutoProperties {
    class Produto {

        // Tornando atributo Preco e Quantidade AUTOPROPERTIES
        /*O Nome não pode se tornar autopropertie por ter uma condição
        especial "IF"*/
        private string _nome;          
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        //...

        //CONSTRUTOR PADRAO
        public Produto() {
        }

        //CONSTRUTOR
        //método utiizando os atributos privados 
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        //Aula 56 Properties
        //Caso não queira utilizar Get e Set
        //Criamos uma Properties utilizando as operações Get e Set

        public string Nome {

            get { return _nome; }

            set {
                if (value != null && value.Length > 1)
                    _nome = value;
            }

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