using System;

namespace _71VetoresExerc {
    class Program {
        static void Main(string[] args) {

            Aluguel[] vetor = new Aluguel[10];

            Console.Write("Quantos quartos serão alugados?: ");
            int n = int.Parse(Console.ReadLine());
           
           
            
            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel: #{i}: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("N° Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vetor[i] = new Aluguel(nome, email,quarto);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (vetor[i] != null) {
                    Console.WriteLine(i + ": " + vetor[i]);
                }
            }
        }
    }
}

