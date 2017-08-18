using System.Linq;

namespace Lanchonete.Descontos
{
    public class MuitaCarne : IDesconto
    {
        public decimal ValorDesconto(Lanche lanche, decimal Total)
        {
            var qtdeCarne = lanche.Ingredientes.Count(c => c.Equals(Ingrediente.HamburgerCarne()));
            int multiplicador = qtdeCarne / 3;
            return multiplicador * Ingrediente.HamburgerCarne().Valor;
        }
    }
}