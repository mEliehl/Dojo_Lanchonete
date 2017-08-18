using Xunit;

namespace Lanchonete.Test
{
    [Collection("bootstrap")]
    public class XEggTest
    {
        [Fact]
        public void Checar_Se_XBacon_Esta_Correto()
        {
            var actual = new XEgg();

            Assert.NotEmpty(actual.Ingredientes);
            Assert.Contains(Ingrediente.Ovo(), actual.Ingredientes);
            Assert.Contains(Ingrediente.HamburgerCarne(), actual.Ingredientes);
            Assert.Contains(Ingrediente.Queijo(), actual.Ingredientes);
            Assert.DoesNotContain(Ingrediente.Alface(), actual.Ingredientes);
            Assert.DoesNotContain(Ingrediente.Bacon(), actual.Ingredientes);
            Assert.Equal(5.3m, actual.Total());
        }
    }
}