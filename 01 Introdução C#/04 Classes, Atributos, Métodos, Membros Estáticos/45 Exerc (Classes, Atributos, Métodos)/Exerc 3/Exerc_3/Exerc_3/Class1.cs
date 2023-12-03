using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_3 {
    class Aluno {

        public string Nome;
        public double nota1,nota2,nota3;

        public double NotaFinal() {
            return nota1 + nota2 + nota3;
        }

        public bool Aprovado() {
            if (NotaFinal() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }

        public double NotasRestantes() {
            if (Aprovado()) {
                return 0.0;
            }
            else {
                return 60.0 - NotaFinal();
            }
        }

        public override string ToString() {

            return ("NOTA FINAL: " + NotaFinal());

            

        }

       



    }
}
