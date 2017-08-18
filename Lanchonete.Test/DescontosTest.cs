using System.Collections.Generic;
using Xunit;

namespace Lanchonete.Test
{
    [Collection("bootstrap")]
    public class DescontosTest
    {
        [Fact]
        public void Criar_Lanche_Com_3_Queijos_3_Hamburgeres_Alface()
        {
            var ingredientes = new List<Ingrediente>()
            {
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),

                Ingrediente.Alface()
            };

            var lanche = new Lanche(ingredientes);
            Assert.Equal(8.46m, lanche.Total());
        }

        [Fact]
        public void Criar_Lanche_Com_3_Queijos_3_Hamburgeres_Alface_Ovo()
        {
            var ingredientes = new List<Ingrediente>()
            {
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),

                Ingrediente.Alface(),
                Ingrediente.Ovo()
            };

            var lanche = new Lanche(ingredientes);
            Assert.Equal(9.18m, lanche.Total());
        }

        [Fact]
        public void Criar_Lanche_Com_3_Queijos_3_Hamburgeres_Alface_Ovo_Bacon()
        {
            var ingredientes = new List<Ingrediente>()
            {
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),

                Ingrediente.Alface(),
                Ingrediente.Ovo(),
                Ingrediente.Bacon()
            };

            var lanche = new Lanche(ingredientes);
            Assert.Equal(12.20m, lanche.Total());
        }
    }
}