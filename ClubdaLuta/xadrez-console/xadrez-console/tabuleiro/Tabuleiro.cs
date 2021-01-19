namespace tabuleiro {
    class Tabuleiro {
        public int LinhasdoTabuleiro { get; set; }
        public int ColunasdoTabuleiro { get; set; }

        private Peca[,] PecanoTabuleiro;

        //Construtor
        public Tabuleiro(int linhas, int colunas) {
            LinhasdoTabuleiro = linhas;
            ColunasdoTabuleiro = colunas;
            PecanoTabuleiro = new Peca[LinhasdoTabuleiro, ColunasdoTabuleiro];
        }

        //Método que permite retornar uma peça.
        public Peca RetornarPecaNoTabuleiro(int linha, int coluna) {
            return PecanoTabuleiro[linha, coluna];
        }

        public Peca Peca(Posicao pos) {
            return PecanoTabuleiro[pos.Linha, pos.Coluna];
        }
        
        public void ColocarPecaNoTabuleiro(PecaGenerica peca, Posicao posicao) {
            if (ExistePeca(posicao))
                throw new TabuleiroException("Já existe uma peça nessa posição!");

            PecanoTabuleiro[posicao.Linha, posicao.Coluna] = peca;
            peca.PosicaodaPeca = posicao;
        }

       
        public bool ExistePeca(Posicao pos) {
            ValidarPosicao(pos);
            return Peca(pos) != null;
        }

        public void ValidarPosicao(Posicao pos) {
            if (!PosicaoValida(pos)) {
                throw new TabuleiroException("Posição inválida!");
            }
        }

        public Peca RetirarPeca(Posicao pos) {
            if (Peca(pos) == null) {
                return null;
            }
            Peca aux = Peca(Posicao);
            aux.Posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        public bool PosicaoValida(Posicao pos) {
            bool linhaEhValida = (pos.Linha < 0 || pos.Linha >= Linhas);
            bool colunaEhValida = (pos.Coluna < 0 || pos.Coluna >= Colunas);
            if (linhaEhValida || colunaEhValida) {
                return false;
            }
            return true;
        }

    }
}