using System;

namespace Parametroparams {
    class Program {
        static void Main(string[] args) {

            //Sem params
            //int s1 = Calculadora.Sum(new int[] { 2, 4 });

            //Com params
            
            int s2 = Calculadora.Sum(2, 4);

            Console.WriteLine(s2);

        }
    }
}
