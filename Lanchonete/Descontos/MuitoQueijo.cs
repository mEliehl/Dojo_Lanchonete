using System.Linq;

namespace Lanchonete.Descontos
{
    public class MuitoQueijo : IDesconto
    {
        public decimal ValorDesconto(Lanche lanche, decimal Total)
        {
            var qtdeQueijo = lanche.Ingredientes.Count(c => c.Equals(Ingrediente.Queijo()));
            int multiplicador = qtdeQueijo / 3;
            return multiplicador * Ingrediente.Queijo().Valor;
        }
    }
}