using Xunit;

namespace Lanchonete.Test
{
    [Collection("bootstrap")]
    public class XBurgerTest
    {
        [Fact]
        public void Checar_Se_XBurger_Esta_Correto()
        {
            var actual = new XBurger();

            Assert.NotEmpty(actual.Ingredientes);
            Assert.Contains(Ingrediente.HamburgerCarne(), actual.Ingredientes);
            Assert.Contains(Ingrediente.Queijo(), actual.Ingredientes);
            Assert.DoesNotContain(Ingrediente.Alface(), actual.Ingredientes);
            Assert.DoesNotContain(Ingrediente.Ovo(), actual.Ingredientes);
            Assert.DoesNotContain(Ingrediente.Bacon(), actual.Ingredientes);
            Assert.Equal(4.5m, actual.Total());
        }
    }
}