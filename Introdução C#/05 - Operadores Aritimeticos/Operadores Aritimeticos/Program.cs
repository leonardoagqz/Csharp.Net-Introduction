using System;

namespace Operadores_Aritimeticos {
    class Program {
        static void Main(string[] args) {


            double a = 1.0, b = -3.0, c = -4.0 ;
            double delta = b * b - 4 * a * c;
            double delta2 = Math.Pow(b, 2.0) - 4.0  * a * c; //funcao b² Math.Pow(b, 2.0)

            double x1 = (-b + Math.Sqrt(delta2))/ (2.0 * a);//funcao raiz² de delta Math.Sqrt(delta2)
            double x2 = (-b - Math.Sqrt(delta2)) / (2.0 * a);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(delta2);
            Console.WriteLine(delta);
            Console.WriteLine(a);
        }
    }
}
