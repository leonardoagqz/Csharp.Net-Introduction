using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
       public class Posicao {

        public int Linha { get; set; }

        public int Coluna { get; set; }

        //Construtor
        public Posicao(int linha, int coluna) {

            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString() {
            return Linha + ", " + Coluna;
        }

    }
}
