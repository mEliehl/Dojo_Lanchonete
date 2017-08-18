using System.Collections.Generic;
using Xunit;

namespace Lanchonete.Test
{
    [Collection("bootstrap")]
    public class MuitaCarneTest
    {
        [Fact]
        public void Criar_Lanche_Com_2_Hamgurgueres()
        {
            var ingredientes = new List<Ingrediente>()
            {
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
            };
            var lanche = new Lanche(ingredientes);

            Assert.Equal(6, lanche.Total());
        }

        [Fact]
        public void Criar_Lanche_Com_3_Hamgurgueres()
        {
            var ingredientes = new List<Ingrediente>()
            {
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
            };
            var lanche = new Lanche(ingredientes);

            Assert.Equal(6, lanche.Total());
        }

        [Fact]
        public void Criar_Lanche_Com_4_Hamgurgueres()
        {
            var ingredientes = new List<Ingrediente>()
            {
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
            };
            var lanche = new Lanche(ingredientes);

            Assert.Equal(9, lanche.Total());
        }

        [Fact]
        public void Criar_Lanche_Com_6_Hamgurgueres()
        {
            var ingredientes = new List<Ingrediente>()
            {
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),

                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
            };
            var lanche = new Lanche(ingredientes);

            Assert.Equal(12, lanche.Total());
        }

        [Fact]
        public void Criar_Lanche_Com_7_Hamgurgueres()
        {
            var ingredientes = new List<Ingrediente>()
            {
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),

                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
                Ingrediente.HamburgerCarne(),
            };
            var lanche = new Lanche(ingredientes);

            Assert.Equal(15, lanche.Total());
        }
    }
}