using System;

namespace Iniciando_Struct {
    class Program {
        static void Main(string[] args) {

            Point p;
            p.X = 10;
            p.Y = 20;

            //imprime (10, 20)
            Console.WriteLine(p);

            p = new Point();

            //imprime (0, 0)
            Console.WriteLine(p);

                

        }
    }
}
