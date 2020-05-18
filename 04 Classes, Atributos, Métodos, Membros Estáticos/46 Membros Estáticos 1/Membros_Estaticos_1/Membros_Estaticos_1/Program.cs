using System;

namespace Membros_Estaticos_1 {
    class Program {

        static double Pi = 3.14;
        static void Main(string[] args) {
            Console.WriteLine("Entre o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: "+ circ);
            Console.WriteLine("Volume: : " + volume);
            Console.WriteLine("Valor de PI: "+Pi);
        }


        /*Definindo que a função Circunferencia é static para poder ser utilizada na Void Main*/
        static double Circunferencia(double r) {
            return 2.0 * Pi * r;

        }

        /*Definindo que a função Volume é static para poder ser utilizada na Void Main*/
        static double Volume(double r) {
            return 4 / 3 * Pi * Math.Pow(r, 3);
        
        }
    }
}
