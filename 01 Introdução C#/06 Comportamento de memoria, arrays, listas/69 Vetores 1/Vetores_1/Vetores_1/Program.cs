using System;

namespace Vetores_1 {
    class Program {
        static void Main(string[] args) {
            /*Programa para ler um número inteiro N e altura de N pessoas.
             Armazene as N alturas em um vetor. Em seguida, mostrar a altura
             média dessas pessoas.*/
            Console.Write("Informe a quantidade de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            //criando vetor e informando a quantidade de posições
            double[] vetor = new double[n];
                                
            int QtdPessoas = 1;
            //laço para percorrer o vetor
            for (int i = 0; i < n; i++)  {
                Console.Write("Informe a Altura da: " + QtdPessoas + " Pessoa: ");
                vetor[i] = double.Parse(Console.ReadLine());
                QtdPessoas++;
            }  

            //somando as aluras e armazenando na variavel soma
            double soma = 0;

            for (int i = 0; i < n; i++) {

                soma += vetor[i];
                    
            }

            //valor média
            double media = soma / n;

            Console.WriteLine("A Média é: "+string.Format("{0:n2}",media));

        }
    }
}
