using System;

namespace Exerc01 {
    class Program {
        static void Main(string[] args) {
            /*Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.*/

            Pessoa A, B;
            A = new Pessoa();
            B = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa (Nome e Idade): ");
            A.nome = (Console.ReadLine());
            A.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: " + A.nome);
            Console.WriteLine("Idade: " + A.idade);
            Console.WriteLine("Dados da Segunda pessoa (Nome e Idade): ");
            B.nome = (Console.ReadLine());
            B.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: " + B.nome);
            Console.WriteLine("Idade: " + B.idade);

            if (A.idade > B.idade) {

                Console.WriteLine("Pessoa mais velha: " + A.nome);
            }
            else {

                Console.WriteLine("Pessoa mais velha: "+ B.nome);

            }

            

        }
    }
}
