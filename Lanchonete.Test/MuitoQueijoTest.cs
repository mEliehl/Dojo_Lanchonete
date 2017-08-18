using System.Collections.Generic;
using Xunit;

namespace Lanchonete.Test
{
    [Collection("bootstrap")]
    public class MuitoQueijoTest
    {
        [Fact]
        public void Criar_Lanche_Com_2_Queijos()
        {
            var ingredientes = new List<Ingrediente>()
            {
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
            };
            var lanche = new Lanche(ingredientes);

            Assert.Equal(3, lanche.Total());
        }

        [Fact]
        public void Criar_Lanche_Com_3_Queijos()
        {
            var ingredientes = new List<Ingrediente>()
            {
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
            };
            var lanche = new Lanche(ingredientes);

            Assert.Equal(3, lanche.Total());
        }

        [Fact]
        public void Criar_Lanche_Com_4_Queijos()
        {
            var ingredientes = new List<Ingrediente>()
            {
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
            };
            var lanche = new Lanche(ingredientes);

            Assert.Equal(4.5m, lanche.Total());
        }

        [Fact]
        public void Criar_Lanche_Com_6_Queijos()
        {
            var ingredientes = new List<Ingrediente>()
            {
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),

                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
            };
            var lanche = new Lanche(ingredientes);

            Assert.Equal(6, lanche.Total());
        }

        [Fact]
        public void Criar_Lanche_Com_7_Queijos()
        {
            var ingredientes = new List<Ingrediente>()
            {
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),

                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
                Ingrediente.Queijo(),
            };
            var lanche = new Lanche(ingredientes);

            Assert.Equal(7.5m, lanche.Total());
        }
    }
}