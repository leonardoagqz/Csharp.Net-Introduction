using System;
using System.Globalization;

namespace Exerc_Membros_Estaticos {

    /*Faça um programa para ler a cotção do dólar, e depois um valor em dólares a ser comprado por uma pessoa em rais. 
     Informa quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6% de IOF sobre o valor em dólar.
    
    Exemplo:
    Qual é a cotção do dólar?: 3.10
    Quantos dólares voçê vai comprar?: 200.00
    Valor a ser pago em reais = 620,00
    
    */
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dólar?: ");
            double CotDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantos dólares voçê vai comprar?: ");
            double ValDolComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.Conversor(CotDolar, ValDolComprar);

            Console.WriteLine("Valor a ser pago em reais = "+ string.Format("{0:n2}", resultado) );
        }
    }
}
