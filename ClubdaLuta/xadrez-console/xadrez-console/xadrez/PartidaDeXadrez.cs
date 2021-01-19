using System;
using tabuleiro;

namespace xadrez {
    class PartidaDeXadrez {
        private Tabuleiro tabuleiro;
        private int turno;
        private Cor JogadorAtual;

        public PartidaDeXadrez() {
            tabuleiro = new Tabuleiro(8, 8);
            turno = 1;
            JogadorAtual = Cor.Branca;
            colocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino) 
        { Peca peca = tabuleiro.RetirarPeca(origem);
            peca.IncrementarQteMovimento();
            Peca PecaCapturada = tabuleiro.RetirarPeca(destino);
            tabuleiro.ColocarPeca(peca, destino);
        }
    }
}
