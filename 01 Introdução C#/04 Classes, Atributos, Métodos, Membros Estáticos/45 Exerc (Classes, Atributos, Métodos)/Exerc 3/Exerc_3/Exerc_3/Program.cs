using System;
using System.Globalization;

namespace Exerc_3 {

    /*Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três
     trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada)
     Ao final , mostrar qual a nota final do aluno no ano. Dizer também se o aluno está 
     APROVADO ou  REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter
     o mínimo para ser aprovado (que é 60 pontos).*/
    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            Console.Write("Nota 1: ");
            aluno.nota1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            aluno.nota2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            aluno.nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine(aluno);

            if (aluno.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTAM " + aluno.NotasRestantes() + " PONTOS PARA MÉDIA 60.0");
            }
        }
    }
}
