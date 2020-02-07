using System;

namespace Exercicio_Proposto_3 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Tipos de Combustiveis");
            Console.WriteLine("");
            Console.WriteLine("Um posto de combustivel deseja determinar qual de seus produtos tem a preferência" +
                              " de seus clientes. Escreva um algoritimo para ler o tipo de combustivel abastecido" +
                              "(1.Alcool, 2.Gasolina, 3.Diesel, 4.Fim) Caso o usuario informe um código invalido " +
                              "deve ser solicitado um novo código correto. Oprograma será encerrado quando o código" +
                              "informado for 4. Deve ser escrito 'MUITO OBRIGADO' e a quantidade de clientes que abas" +
                              "teceram cada tipo de combustivel");
            Console.WriteLine("");
            Console.WriteLine("Informe o tipo de combustivel: (1.Alcool) (2.Gasolina) (3.Diesel) (4.Fim) ");
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4) {

                if (tipo == 1) {
                    alcool = alcool + 1;
                }
                else if (tipo == 2) {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3) {
                    diesel = diesel + 1;
                }


                tipo = int.Parse(Console.ReadLine());

                while (tipo != 1 && tipo != 2 && tipo != 3 && (tipo != 4)) {
                    Console.WriteLine("Opção Incorreta!!! Informe uma das das opções: (1.Alcool) (2.Gasolina) (3.Diesel) (4.Fim) ");
                    tipo = int.Parse(Console.ReadLine());

                }


            }
            Console.WriteLine("");
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }

    }
}
