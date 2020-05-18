using System;
using System.Collections.Generic;
using System.Text;

namespace NunExtenso {
    class Milhar {

        public static int milhar(int m, int c, int d, int u) {

            switch (m) {

                case 1:
                    if (c == 0 && d == 0 && u == 0) {
                        Console.WriteLine(" Um mil ");
                    }
                    else {

                        Console.Write(" Mil ");


                    }

                    break;

                case 2:
                    Console.Write(" Doi mil ");
                    break;
                case 3:
                    Console.Write(" Três mil ");
                    break;
                case 4:
                    Console.Write(" Quatro mil ");
                    break;
                case 5:
                    Console.Write(" Cinco mil ");
                    break;
                case 6:
                    Console.Write(" Seis mil ");
                    break;
                case 7:
                    Console.Write(" Sete mil");
                    break;
                case 8:
                    Console.Write(" Oito mil ");
                    break;
                case 9:
                    Console.Write(" Nove mil ");
                    break;
            }
            return (m);

        }
        
     }
}
