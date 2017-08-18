using System.Collections.Generic;

namespace Lanchonete
{
    public class XEgg : Lanche
    {
        private static IEnumerable<Ingrediente> IngredientesXEgg => new List<Ingrediente>()
            {
                Ingrediente.Ovo(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.Queijo(),
            };

        public XEgg() : base(IngredientesXEgg)
        {
        }
    }
}