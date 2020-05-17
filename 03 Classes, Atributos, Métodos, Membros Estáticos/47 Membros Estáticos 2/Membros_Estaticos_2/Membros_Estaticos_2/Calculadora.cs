using System;
using System.Collections.Generic;
using System.Text;

namespace Membros_Estaticos_2 {
    class Calculadora {

        /*prefixo "static", vai permitir que estes membros sejam chamado
        sem precisar instanciar Objetos*/


        public static double Pi = 3.14;


        public static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r) {

            return 4.0 / 3.0 * Pi * r * r * r;
        }


    }
}
