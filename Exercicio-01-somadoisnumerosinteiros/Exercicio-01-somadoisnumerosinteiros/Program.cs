using System;

namespace Exercicio_01_somadoisnumerosinteiros {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("===Soma de Dois Númeoros inteiros===");
            Console.WriteLine();
            Console.Write("Entre com o primeiro valor inteiro: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.Write("Entre com o segundo valor inteiro: ");
            int valor2 = int.Parse(Console.ReadLine());
            int soma = valor1 + valor2;
            Console.Write("SOMA = " + soma );
        }
    }
}
