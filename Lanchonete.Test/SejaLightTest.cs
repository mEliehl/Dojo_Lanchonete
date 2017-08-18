using System.Collections.Generic;
using Xunit;

namespace Lanchonete.Test
{
    [Collection("bootstrap")]
    public class SejaLightTest
    {
        [Fact]
        public void Criar_Lanche_Com_Alface_Sem_Bacon()
        {
            var ingredientes = new List<Ingrediente>()
            {
              Ingrediente.Alface()
            };

            var lanche = new Lanche(ingredientes);
            Assert.Equal(0.36m, lanche.Total());

        }

        public void Criar_Lanche_Com_Alface_Com_Bacon()
        {
            var ingredientes = new List<Ingrediente>()
            {
              Ingrediente.Alface(),
              Ingrediente.Bacon()
            };

            var lanche = new Lanche(ingredientes);
            Assert.Equal(2.4m, lanche.Total());

        }

        public void Criar_Lanche_Com_Alface_Com_Hamburger()
        {
            var ingredientes = new List<Ingrediente>()
            {
              Ingrediente.Alface(),
              Ingrediente.HamburgerCarne()
            };

            var lanche = new Lanche(ingredientes);
            Assert.Equal(3.06m, lanche.Total());

        }
    }
}