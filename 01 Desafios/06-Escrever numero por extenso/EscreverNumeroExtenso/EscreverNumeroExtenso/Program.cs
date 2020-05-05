using System;

namespace EscreverNumeroExtenso {
    class Program {
        static void Main(string[] args) {

            /*Declaração de variáveis*/

            int valor, m, c, d, u;


            Console.Write("Digite um valor : ");
            string valorstr = Console.ReadLine();
            while (true) {

                Console.WriteLine(" ");


                while (Convert.ToInt32(valorstr) < 0 || Convert.ToInt32(valorstr) > 10000) {
                    Console.Write("Erro: Informe um valor entre 0 e 10.000!!: ");
                    valorstr = Console.ReadLine();

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
                            Console.WriteLine(" Um Mil ");
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
                switch (c) {
                    case 1:
                        if (d == 0 && u == 0) {

                            Console.Write(" cem ");

                        }
                        else { Console.Write(" cento "); }
                        break;

                    case 2: { Console.Write(" duzentos "); break; }
                    case 3: { Console.Write(" trezentos "); break; }
                    case 4: { Console.Write(" quatrocentos "); break; }
                    case 5: { Console.Write(" quinhentos "); break; }
                    case 6: { Console.Write(" seiscentos "); break; }
                    case 7: { Console.Write(" setecentos "); break; }
                    case 8: { Console.Write(" oitocentos "); break; }
                    case 9: { Console.Write(" novecentos "); break; }

                }

                if (c != 0 && d != 0) { Console.Write(" e "); }

                switch (d) {

                    case 1: {

                            switch (u) {

                                case 0: { Console.Write(" dez "); break; }
                                case 1: { Console.Write(" onze "); break; }
                                case 2: { Console.Write(" doze "); break; }
                                case 3: { Console.Write(" treze "); break; }
                                case 4: { Console.Write(" quatorze "); break; }
                                case 5: { Console.Write(" quinze "); break; }
                                case 6: { Console.Write(" dezesseis "); break; }
                                case 7: { Console.Write(" dezessete "); break; }
                                case 8: { Console.Write(" dezoito "); break; }
                                case 9: { Console.Write(" dezenove "); break; }

                            }
                            break;
                        }
                    case 2: { Console.Write(" vinte "); break; }
                    case 3: { Console.Write(" trinta "); break; }
                    case 4: { Console.Write(" quarenta "); break; }
                    case 5: { Console.Write(" cinquenta "); break; }
                    case 6: { Console.Write(" sessenta "); break; }
                    case 7: { Console.Write(" setenta "); break; }
                    case 8: { Console.Write(" oitenta "); break; }
                    case 9: { Console.Write(" noventa "); break; }

                }

                if (d != 1) {
                    if (c != 0 || d != 0 && u != 0) {
                        Console.Write(" e ");
                    }

                    switch (u) {
                        case 1: { Console.Write(" um "); break; }
                        case 2: { Console.Write(" dois "); break; }
                        case 3: { Console.Write(" três "); break; }
                        case 4: { Console.Write(" quatro "); break; }
                        case 5: { Console.Write(" cinco "); break; }
                        case 6: { Console.Write(" seis "); break; }
                        case 7: { Console.Write(" sete "); break; }
                        case 8: { Console.Write(" oito "); break; }
                        case 9: { Console.Write(" nove "); break; }


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


