using System.Collections.Generic;

namespace Lanchonete
{
    public class XBurger : Lanche
    {
        private static IEnumerable<Ingrediente> IngredientesXBurger => new List<Ingrediente>()
            {
                Ingrediente.HamburgerCarne(),
                Ingrediente.Queijo(),
            };
        public XBurger() : base(IngredientesXBurger)
        {
        }
    }
}