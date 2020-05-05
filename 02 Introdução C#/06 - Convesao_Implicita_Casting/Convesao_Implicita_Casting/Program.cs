using System;

namespace Convesao_Implicita_Casting {
    class Program {
        static void Main(string[] args) {

            /*Conversão Implícita: de Float para Double */
            float x = 4.5f;
            double y = x;
            Console.WriteLine("Conversão Implícita: ",y);

            /*Conversão Casting "Fundir" */

            double a;
            int b;
            a = 5.1;
            b = (int)a;
            Console.WriteLine("Conversão Casting: ",b);

            
        }
    }
}
