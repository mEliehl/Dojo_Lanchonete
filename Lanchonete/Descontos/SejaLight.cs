using System.Linq;

namespace Lanchonete.Descontos
{
    public class SejaLight : IDesconto
    {
        public decimal ValorDesconto(Lanche lanche, decimal total)
        {
            var HasBacon = lanche.Ingredientes.Any(a => a.Equals(Ingrediente.Bacon()));
            var HasAlface = lanche.Ingredientes.Any(a => a.Equals(Ingrediente.Alface()));
            if(!HasBacon && HasAlface)
                return total * 0.1m;
            return 0;
        }
    }
}