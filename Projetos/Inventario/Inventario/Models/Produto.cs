using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{
    public class Produto : Item
    {
        public int Quantidade { get; set; }
        public override void Atualizar()
        {
            Console.WriteLine("Insira o novo nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine("Insira o novo preço: ");
            Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a nova quantidade: ");
            Quantidade = int.Parse(Console.ReadLine());
        }

        public static Produto CriarProduto()
        {
            Produto produto = new Produto();

            Console.WriteLine("Insira o nome: ");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Insira o preço: ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            return produto;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine($"ID: {Id}, Produto: {Nome}, Preço: {Preco:C}, Quantidade: {Quantidade}");
        }
    }
}
