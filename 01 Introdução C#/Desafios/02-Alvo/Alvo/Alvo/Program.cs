using System;

namespace Alvo {
    class Program {
        static void Main(string[] args) {

        double Pi = 3.14;

            Console.WriteLine("Informar o Diâmetro do Circulo Maior em Centímetros");
            double diametroAtual = double.Parse(Console.ReadLine());
                        
            double diametroMaior = diametroAtual;
            double diametroMenor = diametroAtual / 6;
            
            double diametro6 = diametroAtual;
            double circ6 = diametro6 * Pi * 2;
            double diametro5 = diametro6 - diametroMenor;
            double circ5 = diametro5 * Pi * 2;
            double diametro4 = diametro5 - diametroMenor;
            double circ4 = diametro4 * Pi * 2;
            double diametro3 = diametro4 - diametroMenor;
            double circ3 = diametro3 * Pi * 2;
            double diametro2 = diametro3 - diametroMenor;
            double circ2 = diametro2 * Pi * 2;
            double diametro1 = diametro2 - diametroMenor;
            double circ1 = diametro1 * Pi * 2;

           double circTotal= (circ6 + circ5 + circ4 + circ3 + circ2 + circ1);
           double Alvo1= circTotal;
           double AlvoTotal= circTotal * 5000;
           
            Console.WriteLine("Papelão necessário para um alvo: " + string.Format("{0:00,0.00}", Alvo1) + " cm2");
            Console.WriteLine("Papelão necessário para 5000 alvos: " + string.Format("{0:00,0.00}", AlvoTotal) + " cm2");

        }
    }
}
