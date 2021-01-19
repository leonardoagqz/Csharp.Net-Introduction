using System;
using tabuleiro;

namespace xadrez_console {
    class Tela {
        public static void ImprimirTabuleironaTela(Tabuleiro tabuleiro) {
            for (int i = 0; i < tabuleiro.LinhasdoTabuleiro; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.ColunasdoTabuleiro; j++) {
                    if (tabuleiro.ColocarPecaNoTabuleiro(i, j) == null) {
                        Console.Write("- ");
                    }
                    else {
                        //Console.Write(tabuleiro.Peca(i, j) + " ");
                        ImprimirPeca(tabuleiro.ColocarPecaNoTabuleiro(i, j));
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirPeca(Peca peca) {
            ConsoleColor aux = Console.ForegroundColor;
            if (peca.Cor != Cor.Branca) {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.Write(peca);
            Console.ForegroundColor = aux;
        }

        public static PosicaoXadrez LerPosicaoXadrez() 
        {
            string s = Console.WriteLine();
            char linha = 
        }
    }
}