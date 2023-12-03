namespace tabuleiro {
    class PecaGenerica {
        public Posicao PosicaodaPeca { get; set; }
        public Cor CordaPeca { get; protected set; } 
        public int QteMovimentosdaPeca { get; protected set; }
        public Tabuleiro TabuleiroRecebePeca { get; protected set; }

        //Construtor
        public PecaGenerica(Tabuleiro tabuleiro, Cor cor) {

            PosicaodaPeca = null;
            TabuleiroRecebePeca = tabuleiro;
            CordaPeca = cor;
            QteMovimentosdaPeca = 0;

                    
        }

        public void IncrementarQteMovimento() {
            PecaGenerica peca = tabuleiro.RetirarPeca}

    }
}
