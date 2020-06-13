using System;

namespace Parte1 {
    class Program {
        static void Main(string[] args) {

            ContaBancaria  conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoinicial = double.Parse(Console.ReadLine());

                //instanciar a Conta com os dados recebidos
                //Quando for utilizar os 3 argumentos (numero da conta, nome do titular e deposito inicial)
                conta = new ContaBancaria(numero,titular,depositoinicial);
            }

            //instanciar a Conta com os dados recebidos
            //Quando for utilizar somente 2 argumentos (numero da conta e nome do titular)
            else { conta = new ContaBancaria(numero, titular); }

            Console.WriteLine(" ");
            Console.WriteLine("Dados da conta: " + conta);

            //Depositando
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine());

            //chamar no objeto conta a operação deposito
            conta.Deposito(deposito);

            Console.WriteLine(" ");
            Console.WriteLine("Dados da conta: " + conta);

            //Sacando
            Console.WriteLine();
            Console.Write("Entre um valor para Saque: ");
            double saque = double.Parse(Console.ReadLine());

            //chamar no objeto conta a operação saque
            conta.Saque(saque);

            Console.WriteLine(" ");
            Console.WriteLine("Dados da conta: " + conta);





        }

        

    }
}
