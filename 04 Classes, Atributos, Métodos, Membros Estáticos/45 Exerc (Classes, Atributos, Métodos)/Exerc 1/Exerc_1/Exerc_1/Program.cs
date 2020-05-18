using System;
using System.Globalization;

namespace Exerc_1 {

    /*Criar um programa para ler os valores da largura e altura de um retângulo. 
      Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.*/

    class Program {

        
        static void Main(string[] args) {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            ret.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            ret.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("AREA = "+ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = "+ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = "+ret.Diagonal().ToString("F2",CultureInfo.InvariantCulture));



        }
    }
}
