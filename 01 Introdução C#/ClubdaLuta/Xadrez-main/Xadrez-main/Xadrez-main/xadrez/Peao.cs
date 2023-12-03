using tabuleiro;

namespace xadrez {
    class Peao : Peca {
        public Peao(Tabuleiro tab, Cor cor)
            : base(tab, cor) {

        }

        public override bool[,] MovimentosPossiveis() {
            throw new System.NotImplementedException();
        }

        public override string ToString() {
            return "P";
        }
    }
}