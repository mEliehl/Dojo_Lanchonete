using System.Collections.Generic;

namespace Lanchonete
{
    public class XEggBacon : Lanche
    {
        private static IEnumerable<Ingrediente> IngredientesXEggBacon => new List<Ingrediente>()
            {
                Ingrediente.Bacon(),
                Ingrediente.Ovo(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.Queijo(),
            };
        public XEggBacon() : base(IngredientesXEggBacon)
        {
        }
    }
}