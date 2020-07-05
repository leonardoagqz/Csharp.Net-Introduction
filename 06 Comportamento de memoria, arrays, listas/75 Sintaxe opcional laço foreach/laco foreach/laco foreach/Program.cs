using System;

namespace laco_foreach {
    class Program {
        static void Main(string[] args) {

            /* Sintaxe opcional e simplifida para percorer coleções  */

            //criado vetor string  e iniciado com seus valores
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            //para cada obejto 'obj' contido em vect, faça:
            foreach (string apelido in vect) {

                Console.WriteLine(apelido);
            }

            Console.WriteLine("-----------------------------");

            //Mesmo processo com o For

            string[] vect2 = new string[] { "Maria2", "Bob2", "Alex2" };

            for (int i = 0; i < vect2.Length; i++) {

                Console.WriteLine(vect2[i]);
            }





        }
    }
}
