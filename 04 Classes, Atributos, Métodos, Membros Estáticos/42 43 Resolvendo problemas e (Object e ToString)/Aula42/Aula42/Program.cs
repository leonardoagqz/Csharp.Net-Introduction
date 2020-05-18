using System;
using System.Globalization;
namespace Aula42 {
    class Program {

        /*Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque). Em seguida:
         
            - Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no estoque)
            - Realizar uma entrada no estoque e mostrar novamente os dados do produto 
            - Realizar uma saída no estoque e mostrar novamente os dados do produto 
            
             
             Para resolver este problema, você deve criar uma CLASSE conforme abaixo:
             
             Produto
               ATRIBUTOS
             -Nome:string
             -Preco: double
             -Quantidade:int
             ---------------
               MÉTODOS
             +ValorTotalEmEstoque():double
             +AdicionarProdutos(quanty:int):void
             +RemoveerProdutos(quanty:int):void
             
             
             */

        static void Main(string[] args) {

            Produto p = new Produto(); // Criando variável e instanciando 

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Dados do Produto: "+ p);
                
        }
    }
}
