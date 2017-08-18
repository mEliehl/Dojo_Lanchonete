using System.Collections.Generic;

namespace Lanchonete
{
    public class XBacon : Lanche
    {
        private static IEnumerable<Ingrediente> IngredientesXBacon => new List<Ingrediente>()
            {
                Ingrediente.Bacon(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.Queijo(),
            };

        public XBacon() : base(IngredientesXBacon)
        {

        }
    }
}