using System;

namespace Exerc_2 {

    /*Fazer um programa para ler os dados de um funcionário (nome, sslário bruto e imposto).
     Em seguida, mostrar os dados do funcionãrio (nome e salário líquido).Em seguida, aumentar
     o salário do funcionário com base em uma porcentagem dada(somente o salário bruto é
     afetado pela porcentagem) e mostrar novamente os dados do funcionário.*/

    class Program {
        static void Main(string[] args) {

            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Funcionário: "+func);
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double percentual = double.Parse(Console.ReadLine());
            func.AumentarSalario(percentual);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: "+func);
        }
    }
}
