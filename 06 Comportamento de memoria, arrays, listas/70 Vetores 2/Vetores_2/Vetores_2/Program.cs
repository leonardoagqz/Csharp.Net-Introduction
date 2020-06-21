using System;

namespace Vetores_2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Quantidade de Produtos");
            int n = int.Parse(Console.ReadLine());

            //criando vetor   //instanciando vetor
            Produto[] vetor = new Produto[n];
            
            //laço para percorrer o vetor
            for (int i = 0; i < n; i++) {

                //fazendo a leitura do nome e do preço
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());

                //recebendo os valores das leituras
                vetor[i] = new Produto { Nome = nome, Preco = preco };

            }

            double soma = 0;
            for (int i = 0; i < n; i++) {

                soma += vetor[i].Preco;
                    
             }

            double media = soma / n;
            Console.WriteLine("A Média é: "+media);
                
        }
    }
}
