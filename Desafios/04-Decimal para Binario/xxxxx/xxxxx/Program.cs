using System;

namespace Desafio04 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o número decimal que deseja converter para binário: ");

            while (true) {
                int numDecimal = int.Parse(Console.ReadLine());

                string numBinario = ConverteDecimalParaBinario(numDecimal);

                Console.WriteLine(numDecimal + " em binário é: " + numBinario);
            }
        }

        static string ConverteDecimalParaBinario(int numDecimal) {
            string numBinario = "";
            int resto = 0;

            if (numDecimal != 0) {
                while (numDecimal > 0) {
                    resto = numDecimal % 2;
                    numDecimal = numDecimal / 2;
                    numBinario = numBinario + resto.ToString();
                }
            }
            else {
                numBinario = "0";
            }

            return InverteString(numBinario);
        }

        public static string InverteString(string str) {
            char[] vetor = str.ToCharArray();
            Array.Reverse(vetor);
            return new string(vetor);
        }
    }
}