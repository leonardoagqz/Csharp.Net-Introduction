using System;
using System.Collections.Generic;
using System.Text;

namespace NunExtenso {
    class Centena {

        public static int centena(int m, int c, int d, int u) {


            switch (c) {
                case 1:
                    if (d == 0 && u == 0) {

                        Console.Write(" Cem ");

                    }
                    else if (m == 0) { Console.Write(" Cento "); }
                    else { Console.Write("cento"); }
                    break;


                case 2: if (m == 0) { Console.Write(" Duzentos "); } else { Console.Write(" duzentos "); } break;
                case 3: if (m == 0) { Console.Write(" Trezentos "); } else { Console.Write(" trezentos "); } break;
                case 4: if (m == 0) { Console.Write(" Quatrocentos "); } else { Console.Write(" quatrocentos "); } break;
                case 5: if (m == 0) { Console.Write(" Quinhentos "); } else { Console.Write(" quinhentos "); } break;
                case 6: if (m == 0) { Console.Write(" Seiscentos "); } else { Console.Write(" seiscentos "); } break;
                case 7: if (m == 0) { Console.Write(" Setecentos "); } else { Console.Write(" setecentos "); } break;
                case 8: if (m == 0) { Console.Write(" Oitocentos "); } else { Console.Write(" oitocentos "); } break;
                case 9: if (m == 0) { Console.Write(" Novecentos "); } else { Console.Write(" novecentos "); } break;

            }
            return (c);

        }

        
     }
}
