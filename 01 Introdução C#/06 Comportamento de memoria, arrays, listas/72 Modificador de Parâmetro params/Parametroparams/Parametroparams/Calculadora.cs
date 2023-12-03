using System;
using System.Collections.Generic;
using System.Text;

namespace Parametroparams {
    
    //Sem params
    /*class Calculadora {
        public static int Sum(params int[] numeros) {
            int sum = 0;
            for (int i = 0; i < numeros.Length; i++) { }
            return sum;
        }
    }*/


    //Com params
    class Calculadora {
        public static int Sum(params int[] numeros) {
            int sum = 0;
            for (int i = 0; i < numeros.Length; i++) {
                sum += numeros[i];
                    }
            return sum;
        }
    }
}
