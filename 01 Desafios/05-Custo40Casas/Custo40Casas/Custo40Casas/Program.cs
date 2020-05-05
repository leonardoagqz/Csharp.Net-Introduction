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
            double A_circulo = (PI * ( (diametroC / 2) * (diametroC / 2))); // ou (PI * Math.Pow((diametroC / 2), 2)) 
            double A_total = (A_retangulo+(A_quadrado*4)+A_triangulo+A_trapezio+(A_circulo*4));

            Console.WriteLine("");
            
            
            //Console.WriteLine("Valor por metro quadrado: R$"+V_pedreiro.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(string.Format("valor por metro quadrado: R$ {0}", string.Format("{0:n2}",V_pedreiro)));
            
            //Console.WriteLine("Área de um quarto: "+A_quadrado.ToString("F2",CultureInfo.InvariantCulture)+" m2");
            Console.WriteLine(string.Format("Área de um quarto: {0}", string.Format("{0:n2}",A_quadrado) + " m2"));

            //Console.WriteLine("Área de um banheiro: "+A_circulo.ToString("F2",CultureInfo.InvariantCulture)+" m2");
            Console.WriteLine(string.Format("Área de um banheiro: {0}", string.Format("{0:n2}",A_circulo) + " m2"));

            //Console.WriteLine("Àrea de um escritório: "+A_triangulo.ToString("F2",CultureInfo.InvariantCulture)+" m2");
            Console.WriteLine(string.Format("Área de um escritório: {0}", string.Format("{0:n2}",A_triangulo) + " m2"));

            //Console.WriteLine("Área das salas: "+A_retangulo.ToString("F2",CultureInfo.InvariantCulture)+" m2");
            Console.WriteLine(string.Format("Área das salas: {0}", string.Format("{0:n2}",A_retangulo) + " m2"));

            //Console.WriteLine("Área da copa e cozinha: "+A_trapezio.ToString("F2",CultureInfo.InvariantCulture)+" m2");
            Console.WriteLine(string.Format("Área da copa e cozinha: {0}", string.Format("{0:n2}", A_trapezio) + " m2"));

            //Console.WriteLine("Área de uma casa: "+A_total.ToString("F2",CultureInfo.InvariantCulture)+" m2");
            Console.WriteLine(string.Format("Área de uma casa: {0}", string.Format("{0:n2}",A_total) + " m2"));

            //Console.WriteLine("Valor mão de obra de uma casa: R$"+(V_pedreiro*A_total).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(string.Format("Valor mão de obra de uma casa: R$ {0}", string.Format("{0:n2}", (V_pedreiro * A_total))));

            //Console.WriteLine("Valor mão de obra condomínio: R$"+(V_pedreiro*A_total*40).ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(string.Format("Valor mão de obra condomínio: R$ {0} ", string.Format("{0:n2}", (V_pedreiro * A_total * 40))));
        }


    }


}