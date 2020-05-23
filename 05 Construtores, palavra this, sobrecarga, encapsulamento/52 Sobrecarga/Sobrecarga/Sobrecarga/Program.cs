using System;
using System.Globalization;
namespace Sobrecarga {
    class Program {

        /*Código da aula 44 reaproveitado para treinamento de Construtores*/



        static void Main(string[] args) {


            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            /*Posso utilizar o construtor com 3 argumentos ou ocontrutor com 2 argumentos
              que foram criados na classe Produto*/
            //Produto produto1 = new Produto(nome, preco, quantidade);
            //Produto produto1 = new Produto(nome, preco);
            Produto produto1 = new Produto(nome, preco);


            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + produto1);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto1.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto1);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
            qte = int.Parse(Console.ReadLine());
            produto1.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto1);


        }
    }
}
