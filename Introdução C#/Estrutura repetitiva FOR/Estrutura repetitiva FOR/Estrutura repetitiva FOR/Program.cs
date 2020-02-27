using System;

namespace Estrutura_repetitiva_FOR {
    class Program {
        static void Main(string[] args) {

            //Primeiro Exemplo

            //Console.WriteLine("Demostração, fazer um programa para digitar um número N e depois N valores inteiros." +
            //    "Mostrar a soma dos N valores digitados");
            //Console.WriteLine("");
            //Console.Write("Quantos números inteiros você vai digitar? ");
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++) {
            //    Console.WriteLine("oi");
            //}

            //Segundo Exemplo

            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= N; i++) {
                Console.Write("Valor #{0}: ", i);
                int valor =int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = "+soma);

        }
    }
}
