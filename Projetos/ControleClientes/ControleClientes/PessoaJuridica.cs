using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    public class PessoaJuridica : Clientes
    {
        public string Cnpj { get; set; }
        public string Ie { get; set; }

        public override void PagarImposto(float v)
        {
            this.Valor = v;
            this.ValorImposto = this.Valor * 30 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}
