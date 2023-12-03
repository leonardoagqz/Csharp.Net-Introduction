using tabuleiro;

namespace xadrez {
    class PosicaoXadrez {
        //properts
        public char Coluna { get; set; }   
        public int Linha { get; set; }

        //construtor   
        public PosicaoXadrez(char coluna, int linha) {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao() {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString() {
            return "" + Coluna + Linha;
        }
    }
}