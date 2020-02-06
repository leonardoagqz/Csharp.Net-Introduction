using System;
using System.Globalization;
namespace Exercicio_02_mostrarvalorareacirculo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("===Este programa irá calcular a área do circulo ===");
            Console.Write("Entre com o valor Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2.0);
            Console.WriteLine("O valor da área é: "+(area.ToString("F4",CultureInfo.InvariantCulture)));
            


        }
    }
}
