using System;

namespace EscreverNumeroExtenso {
    class Program {
        static void Main(string[] args) {

            /*Declaração de variáveis*/

             int valor, m, c, d, u;


            Console.Write("Digite um valor entre 0 e 10.000!!: ");
            string valorstr = Console.ReadLine();
            while (true) {

                Console.WriteLine(" ");


                while (Convert.ToInt32(valorstr) < 0 || Convert.ToInt32(valorstr) > 10000) {
                    Console.WriteLine("Número invalido ");
                    Console.WriteLine(" ");
                    Console.Write("Digite um valor : ");
                    valorstr = Console.ReadLine();
                    Console.WriteLine(" ");

                }

                valor = Convert.ToInt32(valorstr);

                m = valor / 1000;
                if (m == 1 || m == 2 || m == 3 || m == 4 || m == 5 || m == 6 || m == 7 || m == 8 || m == 9 || m == 10) {

                    int milhar = m * 1000;
                    valor = Convert.ToInt32(valorstr) - milhar;

                    c = valor / 100;
                    int centena = c * 100;
                    valor = valor - centena;

                    d = valor / 10;
                    int dezena = d * 10;
                    valor = valor - dezena;

                    u = valor;


                }
                else {
                    c = (valor / 100);
                    d = (valor % 100) / 10;
                    u = (valor % 100) % 10;
                }

                if (m == 0 && c == 0 && d == 0 && u == 0) {

                    Console.WriteLine("zero");

                }

                if (m == 10 && c == 0 && d == 0 && u == 0) {

                    Console.WriteLine("Dez mil");

                }

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

                if (m > 0) {
                    if (c != 0 || d != 0 && u > 0) {
                        Console.Write(" e "); }
                }


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

                if (c != 0 && d != 0) { Console.Write(" e "); }

                switch (d) {

                    case 1: {

                            switch (u) {

                                case 0: if (m == 0 && c ==0) { Console.Write(" Dez "); } else { Console.Write(" dez "); } break;
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

                if (d != 1 && u > 0) {
                    if (m > 0 || c != 0 || d != 0 && u > 0) {
                        Console.Write(" e ");
                    }

                   


                }

                

                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(" ");
                Console.Write("Digite um valor : ");
                valorstr = Console.ReadLine();

            }




        }

        

    }
}


