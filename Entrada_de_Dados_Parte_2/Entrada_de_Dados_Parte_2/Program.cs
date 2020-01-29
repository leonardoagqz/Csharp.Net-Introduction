using System;
using System.Globalization;

namespace Entrada_de_Dados_Parte_2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informe um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("voce digitou: "+ n1);
            Console.WriteLine();
            Console.WriteLine("Informa um caractere: ");
            char carac = char.Parse(Console.ReadLine());
            Console.WriteLine("O caractere digitado é: " + carac);
            Console.WriteLine();
            Console.WriteLine("Informe um valor double: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("O valor double é: " + n2);
            Console.WriteLine();
            Console.WriteLine("Informa na ordem: Nome, sexo Idade, Altura ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Nome: "+nome+" Sexo: "+sexo+" Idade: "+idade+" Altura: "+altura);
            Console.WriteLine();

        }
    }
}
