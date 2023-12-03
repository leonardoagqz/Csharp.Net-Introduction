using System;

namespace NunExtenso {
    class Program {
        static void Main(string[] args) {

            /*Declaração de variáveis*/

            int valor, m, c, d, u;


            Console.Write("Digite um valor entre 0 e 10.000!!: ");
            string valorstr = Console.ReadLine();
            while (true) {

                Console.WriteLine(" ");


                while (Convert.ToInt32(valorstr) < 0 || Convert.ToInt32(valorstr) > 10000) {
                    Console.WriteLine("Número invalido ");
                    Console.WriteLine(" ");
                    Console.Write("Digite um valor : ");
                    valorstr = Console.ReadLine();
                    Console.WriteLine(" ");

                }

                valor = Convert.ToInt32(valorstr);

                m = valor / 1000;
                if (m == 1 || m == 2 || m == 3 || m == 4 || m == 5 || m == 6 || m == 7 || m == 8 || m == 9 || m == 10) {

                    int milhar = m * 1000;
                    valor = Convert.ToInt32(valorstr) - milhar;

                    c = valor / 100;
                    int centena = c * 100;
                    valor = valor - centena;

                    d = valor / 10;
                    int dezena = d * 10;
                    valor = valor - dezena;

                    u = valor;


                }
                else {
                    c = (valor / 100);
                    d = (valor % 100) / 10;
                    u = (valor % 100) % 10;
                }

                if (m == 0 && c == 0 && d == 0 && u == 0) {

                    Console.WriteLine("zero");

                }

                if (m == 10 && c == 0 && d == 0 && u == 0) {

                    Console.WriteLine("Dez mil");

                }

                Milhar.milhar(m, c, d, u);

                if (m > 0) {
                    if (c != 0 || d != 0 && u > 0) {
                        Console.Write(" e ");
                    }
                }

                Centena.centena(m, c, d, u);


                if (c != 0 && d != 0) { Console.Write(" e "); }

                Dezena.dezena(m, c, d, u);

                if (d != 1 && u > 0) {
                    if (m > 0 || c != 0 || d != 0 && u > 0) {
                        Console.Write(" e ");
                    }

                    Unidade.unid(m, c, d, u);


                }



                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(" ");
                Console.Write("Digite um valor : ");
                valorstr = Console.ReadLine();

            }




        }

    }
}
