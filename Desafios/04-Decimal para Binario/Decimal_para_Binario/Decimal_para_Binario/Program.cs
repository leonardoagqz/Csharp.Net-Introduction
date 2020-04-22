using System;

namespace Decimal_para_Binario {
    class Program {
        static void Main(string[] args) {


            Console.WriteLine("Infome valor Decimal!");
            while (true) {

                int xvalorentrada = int.Parse(Console.ReadLine());

                int xdecimal = xvalorentrada;
                string xbinario = "";

                while (xvalorentrada > 0) {

                    int xresto = xvalorentrada % 2;
                    if (xresto == 0) {
                        xbinario = "0" + xbinario;
                    }
                    else {
                        xbinario = "1" + xbinario;

                    }
                    xvalorentrada = xvalorentrada / 2;
                    
                }
                Console.WriteLine(xdecimal + " = " + xbinario);
            }   
         
        }
     }
 }
