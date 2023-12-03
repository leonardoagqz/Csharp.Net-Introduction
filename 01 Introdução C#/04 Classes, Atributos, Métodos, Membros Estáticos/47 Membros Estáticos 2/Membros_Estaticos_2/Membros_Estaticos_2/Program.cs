using System;

namespace Membros_Estaticos_2 {
    class Program {
        static void Main(string[] args) {
            //Calculadora calc = new Calculadora();

            Console.WriteLine("Entre o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ);
            Console.WriteLine("Volume: : " + volume);
            Console.WriteLine("Valor de PI: " + Calculadora.Pi);
        }
    }
}
