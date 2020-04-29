using System;
using System.Globalization;

namespace Custo40Casas {
    class Program {
        static void Main(string[] args) {

            Console.Write("Sálario Mínimo: ");
            double salarioM = double.Parse(Console.ReadLine());
            Console.Write("Valor L: ");
            double L = double.Parse(Console.ReadLine());

            double V_pedreiro = (salarioM * 0.1);
            double diametroC = (L / 2);
            double PI = 3.14;


            double A_retangulo = ((L * 4) * (L * 2));
            double A_quadrado = (L * L);
            double A_triangulo = ((L * L) / 2);
            double A_trapezio = ((((L * 2) + L) / 2) * (L * 0.7));
            double A_circulo = (PI * ((diametroC / 2) * 2));
            double A_total = (A_retangulo+A_quadrado+A_triangulo+A_trapezio+A_circulo);

            Console.WriteLine("");
            Console.WriteLine("Valor por metro quadrado: R$"+V_pedreiro.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Área de um quarto: "+A_quadrado.ToString("F2",CultureInfo.InvariantCulture)+" m2");
            Console.WriteLine("Área de um banheiro: "+A_circulo.ToString("F2",CultureInfo.InvariantCulture)+" m2");
            Console.WriteLine("Àrea de um escritório: "+A_triangulo.ToString("F2",CultureInfo.InvariantCulture)+" m2");
            Console.WriteLine("Área das salas: "+A_retangulo.ToString("F2",CultureInfo.InvariantCulture)+" m2");
            Console.WriteLine("Área da copa e cozinha: "+A_trapezio.ToString("F2",CultureInfo.InvariantCulture)+" m2");
            Console.WriteLine("Área de uma casa: "+A_total.ToString("F2",CultureInfo.InvariantCulture)+" m2");
            Console.WriteLine("Valor mão de obra de uma casa: R$"+(V_pedreiro*A_total).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor mão de obra condomínio: R$"+(V_pedreiro*A_total*40).ToString("F2",CultureInfo.InvariantCulture));

        }


    }


}