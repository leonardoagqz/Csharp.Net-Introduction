using System;
using System.Collections.Generic;
using System.Text;

namespace NunExtenso {
    class Unidade {

        public static int unid(int m, int c, int d, int u) {

            switch (u) {
                case 1: if (m == 0 && c == 0 && d == 0) { Console.Write(" Um "); } else { Console.Write(" um "); } break;
                case 2: if (m == 0 && c == 0 && d == 0) { Console.Write(" Dois "); } else { Console.Write(" dois "); } break;
                case 3: if (m == 0 && c == 0 && d == 0) { Console.Write(" Três "); } else { Console.Write(" três "); } break;
                case 4: if (m == 0 && c == 0 && d == 0) { Console.Write(" Quatro "); } else { Console.Write(" quatro "); } break;
                case 5: if (m == 0 && c == 0 && d == 0) { Console.Write(" Cinco "); } else { Console.Write(" cinco "); } break;
                case 6: if (m == 0 && c == 0 && d == 0) { Console.Write(" Seis "); } else { Console.Write(" seis "); } break;
                case 7: if (m == 0 && c == 0 && d == 0) { Console.Write(" Sete "); } else { Console.Write(" sete "); } break;
                case 8: if (m == 0 && c == 0 && d == 0) { Console.Write(" Oito "); } else { Console.Write(" oito "); } break;
                case 9: if (m == 0 && c == 0 && d == 0) { Console.Write(" Nove "); } else { Console.Write(" nove "); } break;


            }

            return u;

        }

    }
}
