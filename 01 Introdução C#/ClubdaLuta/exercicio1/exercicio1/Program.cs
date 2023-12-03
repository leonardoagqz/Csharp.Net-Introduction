using System;


namespace exercicio1 {
    class Program {
        static void Main(string[] args) {
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