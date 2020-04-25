using System;

namespace Desafio3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Altura do prego: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Ângulo formado entre a escada e o chão: ");
            double graus = double.Parse(Console.ReadLine());

            double tamanhoEscada = altura / GetSeno(graus);

            double distanciaEntreDegraus = 0.3;

            Console.WriteLine("Quantidade de degraus: " + (int)(tamanhoEscada / distanciaEntreDegraus));
        }

        static public double GetSeno(double graus) {
            double radianos = ConverteGrausParaRadiano(graus);
            return Math.Sin(radianos);
        }

        static public double ConverteGrausParaRadiano(double graus) {
            return graus * (Math.PI / 180);
        }
    }
}
