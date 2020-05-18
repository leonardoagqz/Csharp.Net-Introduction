using System;

namespace Exerc02 { /* Programa lê o nome e o salário de dois funcionarios. Depois, mostra o salário
    médio dos funcionários*/


    class Program {
        static void Main(string[] args) {

            Funcionario A, B;

            A = new Funcionario();
            B = new Funcionario();  

            Console.WriteLine("Dados do primeiro funcionário (Nome e Salário): ");
            Console.Write("Nome: "); 
            A.nome = Console.ReadLine();
            Console.Write("Salário: ");
            A.salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário (Nome e Salário): ");
            Console.Write("Nome: ");
            B.nome = Console.ReadLine();
            Console.Write("Salário: ");
            B.salario = double.Parse(Console.ReadLine());

            double media = (A.salario + B.salario)/2;

            Console.WriteLine("Salário médio = "+ media);





        }

    }

}