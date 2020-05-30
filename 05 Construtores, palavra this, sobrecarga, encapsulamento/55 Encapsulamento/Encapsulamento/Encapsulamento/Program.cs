using System;
using System.Globalization;
namespace Encapsulamento {
    class Program {

       
        static void Main(string[] args) {


            Produto prod = new Produto("TV",500,10);

            prod.SetNome("TV 4k");

            Console.WriteLine(prod.GetNome());
            Console.WriteLine(prod.GetPreco());
            Console.WriteLine(prod.GetQuantidade());

        }
    }
}
