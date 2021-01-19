using tabuleiro;

namespace xadrez {
    class Dama : Peca {
        public Dama(Tabuleiro tab, Cor cor)
            : base(tab, cor) {

        }

        public override bool[,] MovimentosPossiveis() {
            throw new System.NotImplementedException();
        }

        public override string ToString() {
            return "D";
        }
    }
}