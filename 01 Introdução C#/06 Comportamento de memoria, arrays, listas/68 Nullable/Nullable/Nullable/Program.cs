using System;

namespace Nullable {
    class Program {
        static void Main(string[] args) {

            double? x = null;
            double? y = 10;

            //não imprime nada
            Console.WriteLine(x);

            //imprime zero  //pega o valor que esta em x ou o valor default 
            Console.WriteLine(x.GetValueOrDefault());

            //imprime 10   
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);//imprime False
            Console.WriteLine(y.HasValue);//imprime True


            if (x.HasValue)
                Console.WriteLine(x.Value);//
            else
                Console.WriteLine("X é Null");
            if (y.HasValue)
                Console.WriteLine(y.Value);//imprime 10
            else
                Console.WriteLine("Y é Null");

            Console.WriteLine();
            //Operador de coalescência nula
            Console.WriteLine("*** Exemplo de Operador de Coalescência Nula ***");

            double? a = null;

            //se a tiver valor b recebe o valor de a se não recebe 0.0
            double  b = a ?? 0.0;


            Console.WriteLine(a);//imprime nada
            Console.WriteLine(b);//imprime 0.0, pois a não tem valor
        }
    }
}
