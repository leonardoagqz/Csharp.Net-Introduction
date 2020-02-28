using System;

namespace exercicio1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X," +
                " um valor por linha, inclusive o X, se for o caso.");
            Console.WriteLine("");
            Console.Write("Informe o valor: ");
            double x = double.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
