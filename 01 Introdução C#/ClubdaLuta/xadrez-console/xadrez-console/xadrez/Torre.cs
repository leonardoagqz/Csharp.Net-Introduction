using tabuleiro;

namespace xadrez {
    class Torre : PecaGenerica {
        public Torre(Tabuleiro tabuleiro, Cor cor)
            : base(tabuleiro, cor) {

        }

        public override string ToString() {
            return "T";
        }
    }
}