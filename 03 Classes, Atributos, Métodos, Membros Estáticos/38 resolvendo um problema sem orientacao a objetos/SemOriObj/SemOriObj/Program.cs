using System;
using System.Globalization;
namespace SemOriObj {
    class Program {
        static void Main(string[] args) {
            //criando variáveis do triângulo x e y

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double xp = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(xp * (xp - xA) * (xp - xB) * (xp - xC));
            
            double yp = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(yp * (yp - yA) * (yp - yB) * (yp - yC));


            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));


            if (areaX > areaY) {
                Console.WriteLine("Área Maior: X");
            }
            else { Console.WriteLine("Área Maior: Y"); }

        }
    }
}
