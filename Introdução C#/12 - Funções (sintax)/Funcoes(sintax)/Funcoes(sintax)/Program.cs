using System;

namespace Funcoes_sintax_ {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Descobrir o maior de três números");
            Console.WriteLine("");
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            //chamando a funcao
            int resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);

        }

        //criando a funcao
        //static = para poder funcionar dentro da funcao principal ^
        //int = o tipo da saida da funcao
        //Maior = nome da funcao
        //() = parametros, dados de entrada da funcao
        static int Maior(int x, int y, int z) {
            int maior;
            if (x > y && x > z) {
                maior = x;
            }
            else if (y > z) {
                maior = y;
            }
            else {
                maior = z;
            }
            return maior;


        }
    }


}

