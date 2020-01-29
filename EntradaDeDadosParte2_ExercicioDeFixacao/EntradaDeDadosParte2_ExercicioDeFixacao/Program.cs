using System;
using System.Globalization;

namespace EntradaDeDadosParte2_ExercicioDeFixacao {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine( "Entre com seu nome completo: " );
            string nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Quantos quartos tem sua casa? ");
            int quarto = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Entre com seu último nome, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2],CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();


        }
    }
}
