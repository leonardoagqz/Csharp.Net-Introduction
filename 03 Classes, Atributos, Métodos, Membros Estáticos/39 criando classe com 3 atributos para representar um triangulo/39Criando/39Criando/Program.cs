using System;
using System.Globalization;
namespace _39Criando { /*Criando uma classe com três atributos para representar melhor o triângulo.*/
    class Program {
        static void Main(string[] args) {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();



            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double xp = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(xp * (xp - x.A) * (xp - x.B) * (xp - x.C));

            double yp = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(yp * (yp - y.A) * (yp - y.B) * (yp - y.C));


            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));


            if (areaX > areaY) {
                Console.WriteLine("Área Maior: X");
            }
            else { Console.WriteLine("Área Maior: Y"); }

        }
    }
}
