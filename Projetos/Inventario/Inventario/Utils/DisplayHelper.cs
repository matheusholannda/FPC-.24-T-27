using Inventario.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Utils
{
    public static class DisplayHelper
    {
        public static void MostrarInventario(InventarioService inventarioService)
        {
            var itens = inventarioService.ListarItens();
            foreach (var item in itens)
            {
                item.MostrarDetalhes();
            }
        }
    }
}
