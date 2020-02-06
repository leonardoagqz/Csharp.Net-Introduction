using System;

namespace Exercicio_Proposto_1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(" *** Exercício Proposto 1 ***");
            Console.WriteLine("");
            Console.WriteLine("Escreva um programa que repita a leitura de uma senha até que ela seja" +
                              "válida. Para cada leitura de senha incorreta informada, escrever a " +
                              "mensagem ''Senha Invalida''.Quando a senha for informada corretamente " +
                              "deve ser impressa a mensagem ''Acesso Permitido'' e o algoritmo encerrado." +
                              "Considere que a senha correta é o valor 2002.");
            Console.WriteLine("");
            Console.WriteLine("Informe a senha");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                
                Console.WriteLine("Senha Incorreta!");
                senha = int.Parse(Console.ReadLine());             
            }
            Console.WriteLine("Acesso Permitido");

        }
    }
}
