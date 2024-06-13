using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    public class PessoaFisica : Clientes
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
    }
}
