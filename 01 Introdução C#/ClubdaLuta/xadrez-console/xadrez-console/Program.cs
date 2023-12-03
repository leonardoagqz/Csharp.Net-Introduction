using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            try {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                tabuleiro.ColocarPecaNoTabuleiro(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
                tabuleiro.ColocarPecaNoTabuleiro(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
                tabuleiro.ColocarPecaNoTabuleiro(new Rei(tabuleiro, Cor.Branca), new Posicao(0, 2));
                tabuleiro.ColocarPecaNoTabuleiro(new Torre(tabuleiro, Cor.Branca), new Posicao(3, 5));
                
                Tela.ImprimirTabuleironaTela(tabuleiro);

                Console.ReadLine(); Console.ReadLine();
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}