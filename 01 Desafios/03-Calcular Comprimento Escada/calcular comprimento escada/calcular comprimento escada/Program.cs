using System;
using System.Globalization;

namespace calcular_comprimento_escada {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Você deseja martelar o prego em que altura? ");
            Console.Write("Informe a Altura em Metros: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Em que angulo a escada ficará?");
            Console.Write("Informe o Angulo: ");
            double angulo = double.Parse(Console.ReadLine());
            
            double pi = 3.14;
            double seno90 = Math.Ceiling(Math.Sin(90));
            double senouser = Math.Sin((angulo*(pi/180)));

            double hipo = (altura * seno90) / senouser;

            Console.WriteLine("Comprimento da Escada: " + ( hipo.ToString("F2", CultureInfo.InvariantCulture) + " Metros"));
        }
    }
}
