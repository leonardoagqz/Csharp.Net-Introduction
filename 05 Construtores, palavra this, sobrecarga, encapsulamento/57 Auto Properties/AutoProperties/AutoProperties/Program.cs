using System;
using System.Globalization;
namespace AutoProperties {
    class Program {


        static void Main(string[] args) {


            Produto prod = new Produto("TV", 500, 10);

            prod.Nome = "TV 4k";

            Console.WriteLine(prod.Nome);
            Console.WriteLine(prod.Preco);
            Console.WriteLine(prod.Quantidade);

        }
    }
}