using System;
using System.Globalization;//para conseguir utilizar ponto (CultureInfo)
namespace Estrutura_Repetitiva_While {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Estrutura Repetitiva While");
            Console.WriteLine("");
            Console.WriteLine("Digitar um número e mostrar sua raiz quadrada com três casas decimais" +
                            ", depois repetir o procedimento. Quando o usuário digitar um número negativo" +
                            "(podendo inclusive ser na primeira vez), mostrar uma mensagem" +
                            "''Número negativo'' e terminar o programa. ");

            Console.WriteLine("");

            Console.Write("Digite um número: ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (num >= 0.0) { 
            double raiz = Math.Sqrt(num);
            Console.WriteLine("Raiz Quadrada: " + raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("Número negativo");


            /*

             Estrutura "Enquanto"

            while (condição){
                comando1
                comando2
            }


             */

        }
    }
}
