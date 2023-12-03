using System;

namespace Alvo_raio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Informar o Diâmetro do Circulo Maior em Centímetros");
            double diametroAtual = double.Parse(Console.ReadLine());

            double raio6 = diametroAtual / 2;
            double raio1 = raio6 / 6;
            double raio2 = 2 * raio1;
            double raio3 = 3 * raio1;
            double raio4 = 4 * raio1;
            double raio5 = 5 * raio1;
            double alvo1 = 3.14 * raio1 * raio1;
            double alvo2 = 3.14 * raio2 * raio2;
            double alvo3 = 3.14 * raio3 * raio3;
            double alvo4 = 3.14 * raio4 * raio4;
            double alvo5 = 3.14 * raio5 * raio5;
            double alvo6 = 3.14 * raio6 * raio6;
            double alvo = alvo1 + alvo2 + alvo3 + alvo4 + alvo5 + alvo6;
            double alvototal = alvo * 5000;
            Console.WriteLine("Papelão necessário para um alvo: " + string.Format("{0:00,0.00}", alvo) + " cm2");
            Console.WriteLine("Papelão necessário para 5000 alvos: " + string.Format("{0:00,0.00}", alvototal) + " cm2");



        }
    }
}
