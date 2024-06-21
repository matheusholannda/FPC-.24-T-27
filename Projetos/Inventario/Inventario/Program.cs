using Inventario.Models;
using Inventario.Services;
using Inventario.Utils;

InventarioService inventarioService = new InventarioService();
bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("---------- Sistema de Inventário do Holandinha ----------");
    Console.WriteLine();
    Console.WriteLine("1. Adicionar Produto ...................................:");
    Console.WriteLine("2. Adicionar Serviço ...................................:");
    Console.WriteLine("3. Listar Itens ........................................:");
    Console.WriteLine("4. Atualizar Item ......................................:");
    Console.WriteLine("5. Remover Item ........................................:");
    Console.WriteLine("6. Sair ................................................:");
    Console.WriteLine("Escolha uma opção");
    Console.WriteLine();

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Produto produto = Produto.CriarProduto();
            inventarioService.AdicionarItem(produto);
            break;
        case 2:
            Servico servico = Servico.CriarServico();
            inventarioService.AdicionarItem(servico);
            break;
        case 3:
            DisplayHelper.MostrarInventario(inventarioService);
            break;
        case 4:
            AtualizarItem(inventarioService);
            break; 
        case 5:
            RemoverItem(inventarioService);
            break;
        case 6:
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção inválida, tente novamente...");
            break;
    }

    if (continuar)
    {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}

void AtualizarItem(InventarioService inventarioService)
{
    Console.Write("\nDigite o ID do item a ser atualizado: ");
    int id = Convert.ToInt32(Console.ReadLine());
    
    Item item = inventarioService.BuscarPorId(id);

    if (item != null)
    {
        if (item is Produto produto)
        {
            produto.Atualizar();
        } else if (item is Servico servico)
        {
            servico.Atualizar();
        }
    } else
    {
        Console.WriteLine("Item não encontrado, tente novamente...");
    }
}

void RemoverItem(InventarioService inventarioService)
{
    Console.Write("\nDigite o ID do item a ser removido: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Item item = inventarioService.BuscarPorId(id);

    if (item != null)
    {
        inventarioService.RemoverItem(item);
        Console.WriteLine("Item removido com sucesso!");
    } else
    {
        Console.WriteLine("Item não encontrado, tente novamente...");
    }
}