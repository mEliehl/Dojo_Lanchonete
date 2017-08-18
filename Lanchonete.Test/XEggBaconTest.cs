using Xunit;

namespace Lanchonete.Test
{
    [Collection("bootstrap")]
    public class XEggBaconTest
    {
        [Fact]
        public void Checar_Se_XBacon_Esta_Correto()
        {
            var actual = new XEggBacon();

            Assert.NotEmpty(actual.Ingredientes);
            Assert.Contains(Ingrediente.Ovo(), actual.Ingredientes);
            Assert.Contains(Ingrediente.HamburgerCarne(), actual.Ingredientes);
            Assert.Contains(Ingrediente.Bacon(), actual.Ingredientes);
            Assert.Contains(Ingrediente.Queijo(), actual.Ingredientes);
            Assert.DoesNotContain(Ingrediente.Alface(), actual.Ingredientes);
            Assert.Equal(7.3m, actual.Total());
        }
    }
}