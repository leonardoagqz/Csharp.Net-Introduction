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

            Produto produto1 = new Produto(); // Criando variável e instanciando 

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            produto1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto1.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: "+ produto1);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: "+ produto1);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
            qte = int.Parse(Console.ReadLine());
            produto1.RemoverProdutos(qte);
            Console.WriteLine( );
            Console.WriteLine("Dados atualizados: " + produto1);


        }
    }
}
