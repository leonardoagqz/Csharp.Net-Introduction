using System;
using System.Globalization;

namespace ExercicodeFixacao {
    class Program {

         static void Main (string[] args) {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1+","+ "cujo preco e $" + preco1);
            Console.WriteLine(produto2+ ","+"cujo preco e $"+ preco2);
            Console.WriteLine("");
            Console.WriteLine("Registro: "+ idade+ "anos de idade "+","+"codigo "+codigo+ "e "+ "genero "+ genero);
            Console.WriteLine("");
            Console.WriteLine("Medida com oito casas decimais: "+medida.ToString("F8", CultureInfo.InvariantCulture) );
            Console.WriteLine("Arredondando tres casas decimais: "+ medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: "+ medida.ToString("F3"));
        }
    }
}
