namespace tabuleiro {
    class Tabuleiro {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] _pecas;

        public Tabuleiro(int linhas, int colunas) {
            Linhas = linhas;
            Colunas = colunas;
            _pecas = new Peca[Linhas, Colunas];
        }

        public Peca Peca(Posicao pos) {
            return _pecas[pos.Linha, pos.Coluna];
        }

        public Peca Peca(int linha, int coluna) {
            return _pecas[linha, coluna];
        }

        public void ColocarPeca(Peca peca, Posicao posicao) {
            if (ExistePeca(posicao))
                throw new TabuleiroException("Já existe uma peça nessa posição!");

            _pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public Peca RetirarPeca(Posicao posicao) {
            if (Peca(posicao) == null)
                return null;

            Peca aux = Peca(posicao);
            aux.Posicao = null;
            _pecas[posicao.Linha, posicao.Coluna] = null;
            return aux;
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
