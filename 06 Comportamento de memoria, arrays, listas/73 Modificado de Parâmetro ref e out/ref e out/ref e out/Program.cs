using System;

namespace ref_e_out {
    class Program {
        static void Main(string[] args) {

            //resolvendo sem ref e out 
            int x = 10;
            int res = Calculadora.Triple(x);
            Console.WriteLine(res);

            //utilizando o ref
            //variavel y é obrigada a ter um valor.
            int y= 20;
            Calculadora.Triple_ref(ref y);
            Console.WriteLine(y);

            //utilizando o out
            //z recebe o valor e tri retorna o valor triplicado
            int z = 30;
            int tri;
            Calculadora.Triple_out(z, out tri);
            Console.WriteLine(tri);

        }
    }
}
