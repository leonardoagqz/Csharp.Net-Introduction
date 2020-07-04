using System;
using System.Collections.Generic;
using System.Text;

namespace ref_e_out {
    class Calculadora {

        //resolvendo sem ref e out
        public static int Triple(int x) {

            x = x * 3;
            return x;
        }


        //utilizando o ref
        public static void Triple_ref(ref int x) {

            x = x * 3;
        }

        //utilizando o out
        public static void Triple_out(int origin, out int result) {

            result = origin * 3;
        }

    }
}
