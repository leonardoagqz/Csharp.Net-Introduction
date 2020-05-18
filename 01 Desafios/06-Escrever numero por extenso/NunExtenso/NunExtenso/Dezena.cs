using System;
using System.Collections.Generic;
using System.Text;

namespace NunExtenso {
    class Dezena {

        public static int dezena(int m, int c, int d, int u) {
            switch (d) {

                case 1: {

                        switch (u) {

                            case 0: if (m == 0 && c == 0) { Console.Write(" Dez "); } else { Console.Write(" dez "); } break;
                            case 1: if (m == 0 && c == 0) { Console.Write(" Onze "); } else { Console.Write(" onze "); } break;
                            case 2: if (m == 0 && c == 0) { Console.Write(" Doze "); } else { Console.Write(" doze "); } break;
                            case 3: if (m == 0 && c == 0) { Console.Write(" Treze "); } else { Console.Write(" treze "); } break;
                            case 4: if (m == 0 && c == 0) { Console.Write(" Quatorze "); } else { Console.Write(" quatorze "); } break;
                            case 5: if (m == 0 && c == 0) { Console.Write(" Quinze "); } else { Console.Write(" quinze "); } break;
                            case 6: if (m == 0 && c == 0) { Console.Write(" Dezesseis "); } else { Console.Write(" dezeseis "); } break;
                            case 7: if (m == 0 && c == 0) { Console.Write(" Dezessete "); } else { Console.Write(" dezessete "); } break;
                            case 8: if (m == 0 && c == 0) { Console.Write(" Dezoito "); } else { Console.Write(" dezoito "); } break;
                            case 9: if (m == 0 && c == 0) { Console.Write(" Dezenove "); } else { Console.Write(" dezenove "); } break;

                        }
                        break;
                    }
                case 2: if (m == 0 && c == 0) { Console.Write(" Vinte "); } else { Console.Write(" vinte "); } break;
                case 3: if (m == 0 && c == 0) { Console.Write(" Trinta "); } else { Console.Write(" trinta "); } break;
                case 4: if (m == 0 && c == 0) { Console.Write(" Quarenta "); } else { Console.Write(" quarenta "); } break;
                case 5: if (m == 0 && c == 0) { Console.Write(" Cinquenta "); } else { Console.Write(" cinquenta "); } break;
                case 6: if (m == 0 && c == 0) { Console.Write(" Sessenta "); } else { Console.Write(" sessenta "); } break;
                case 7: if (m == 0 && c == 0) { Console.Write(" Setenta "); } else { Console.Write(" setenta "); } break;
                case 8: if (m == 0 && c == 0) { Console.Write(" Oitenta "); } else { Console.Write(" oitenta "); } break;
                case 9: if (m == 0 && c == 0) { Console.Write(" Noventa "); } else { Console.Write(" noventa "); } break;

            }

            return (d);
        }
    }
}
