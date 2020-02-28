using System;

namespace execicio2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Leia um valor inteiro N. Este valor será a quantidade de valores " +
                "inteiros X que serão lidos em seguida. Mostre quantos destes valores X estão dentro" +
                " do intervalo[10, 20] e quantos estão fora do intervalo, mostrando essas informações" +
                " conforme exemplo(use a palavra 'in' para dentro do intervalo, e 'out' para fora do" +
                " intervalo).");
            Console.WriteLine("");
            Console.Write("Quantos números você irá verificar se estão entre 10 e 20?: ");
            
            int n = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;
            //enquanto i for menor igual a n, i+1; 
            for (int i = 1;  i <= n; i++) {
                int j = i; 
                               
                    Console.Write("Informe o  número "+j+" :");
                
                int x = int.Parse(Console.ReadLine());
                    if (x >= 10 && x <= 20) {
                        dentro = dentro + 1;
                    }
                    else {
                        fora = fora + 1;

                    
                }
            }

            Console.WriteLine(dentro + " Estão dentro");
            Console.WriteLine(fora + " Estão fora");


        }
    }
}
