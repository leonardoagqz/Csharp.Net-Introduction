using tabuleiro;

namespace xadrez {
    class PosicaoXadrez {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha) {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao() {
            ValidaPosicao();
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public void ValidaPosicao() {
            if (Coluna < 'a' || Coluna > 'h') {
                throw new TabuleiroException("Nome da coluna inválido!");
            }
            if (Linha < 1 || Linha > 8) {
                throw new TabuleiroException("Número da linha inválido!");
            }
        }

        public override string ToString() {
            return "" + Coluna + Linha;
        }
    }
}