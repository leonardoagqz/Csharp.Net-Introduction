using tabuleiro;

namespace xadrez {
    class Rei : PecaGenerica {

        //Contrutor do Rei
        public Rei(Tabuleiro tabuleiro, Cor cor)
            : base(tabuleiro, cor) {

        }

        //Quando a sub classe Rei for acesada irá retornar 'R'
        public override string ToString() {
            return "R";
        }
    }
}