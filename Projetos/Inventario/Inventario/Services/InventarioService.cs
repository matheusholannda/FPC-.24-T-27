using Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Services
{
    public class InventarioService
    {
        private List<Item> _itens;

        public InventarioService()
        {
            _itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            _itens.Add(item);
        }

        public List<Item> ListarItens() {
            return _itens;
        }

        public Item BuscarPorId(int id)
        {
            return _itens.FirstOrDefault(i => i.Id == id);
        }

        public void RemoverItem(Item item)
        {
            _itens.Remove(item);
        }
    }
}
