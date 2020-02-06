using System;
using System.Globalization;

namespace CourseSaidadeDados {
    class Program {
        static void Main(string[] args) {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Leonardo Aguiar";
            Console.WriteLine("Ola Mundo!");
            Console.WriteLine("Boa Noite!!");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Placeholders = Espacos Reservados em ordem por numeros em chaves {0}{1}{2}");
            Console.WriteLine(" ");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F3} reais", nome,idade,saldo.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Interpolacao: Seta a variavel diretamente no lugar dos numeros ");
            Console.WriteLine(" ");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F3", CultureInfo.InvariantCulture)} reais");
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F3"));
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
