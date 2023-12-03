using System;

namespace Entrada_de_Dados___Parte_1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Escreva algo.");
            Console.WriteLine();
            string frase = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Diga uma cor.");
            Console.WriteLine();
            string x = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Agora outra.");
            Console.WriteLine();
            string y = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Mais uma.");
            Console.WriteLine();
            string z = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escreva três palavras dando espaço na linha. ");
            Console.WriteLine();
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string v0 = vet[0];
            string v1 = vet[1];
            string v2 = vet[2];
            Console.WriteLine();
            Console.WriteLine("Voce digitou: " );
            Console.WriteLine();
            Console.WriteLine(frase);
            Console.WriteLine();
            Console.WriteLine("Primeira cor: " + x);
            Console.WriteLine();
            Console.WriteLine("Segunda cor: " + y);
            Console.WriteLine();
            Console.WriteLine("Terceira cor: " + z);
            Console.WriteLine();
            Console.WriteLine(v0+" "+v1+" "+v2);



        }
    }
}
