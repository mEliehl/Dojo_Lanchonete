using Lanchonete;
using Xunit;

namespace Lanchonete.Test
{
    [Collection("bootstrap")]
    public class XBaconTest
    {
        [Fact]
        public void Checar_Se_XBacon_Esta_Correto()
        {
            var actual = new XBacon();

            Assert.NotEmpty(actual.Ingredientes);
            Assert.Contains(Ingrediente.Bacon(), actual.Ingredientes);
            Assert.Contains(Ingrediente.HamburgerCarne(), actual.Ingredientes);
            Assert.Contains(Ingrediente.Queijo(), actual.Ingredientes);
            Assert.DoesNotContain(Ingrediente.Alface(), actual.Ingredientes);
            Assert.DoesNotContain(Ingrediente.Ovo(), actual.Ingredientes);
            Assert.Equal(6.5m, actual.Total());
        }
    }
}