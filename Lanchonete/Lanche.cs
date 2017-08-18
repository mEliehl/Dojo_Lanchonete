using System;
using System.Collections.Generic;
using System.Linq;
using Lanchonete.Descontos;

namespace Lanchonete
{
    public class Lanche
    {
        public Lanche(IEnumerable<Ingrediente> Ingredientes)
        {
            this.Ingredientes = Ingredientes;
        }

        public IEnumerable<Ingrediente> Ingredientes { get; private set; } = new List<Ingrediente>();

        public decimal Total()
        {
            var total = Ingredientes.Sum(s => s.Valor);
            var descontos = ListaDeDescontoProxy.GetInstance().GetDescontos();
            foreach(var desconto in descontos)
            {
                total -= desconto.ValorDesconto(this,total);
            }
            return total;
        }
    }
}
