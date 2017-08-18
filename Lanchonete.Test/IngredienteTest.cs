using System;
using Xunit;

namespace Lanchonete.Test
{
    [Collection("bootstrap")]
    public class IngredienteTest
    {
        [Fact]
        public void Checar_Se_Bacon_Equal_Bacon()
        {
            Assert.True(Ingrediente.Bacon().Equals(Ingrediente.Bacon()));
        }

        [Fact]
        public void Checar_Se_Bacon_Not_Equal_Alface()
        {
            Assert.False(Ingrediente.Bacon().Equals(Ingrediente.Alface()));
        }

        [Fact]
        public void Checar_Se_Bacon_Not_Equal_String()
        {
            Assert.False(Ingrediente.Bacon().Equals("Bacon"));
        }

        [Fact]
        public void Checar_Se_Alface_Esta_Correto()
        {
            var actual = Ingrediente.Alface();

            Assert.Equal("Alface",actual.Nome);
            Assert.Equal(.4m,actual.Valor);
        }
        
        [Fact]
        public void Checar_Se_Bacon_Esta_Correto()
        {
            var actual = Ingrediente.Bacon();

            Assert.Equal("Bacon",actual.Nome);
            Assert.Equal(2,actual.Valor);
        }

        [Fact]
        public void Checar_Se_HamburgerCarne_Esta_Correto()
        {
            var actual = Ingrediente.HamburgerCarne();

            Assert.Equal("Hambúrguer de carne",actual.Nome);
            Assert.Equal(3,actual.Valor);
        }

        [Fact]
        public void Checar_Se_Ovo_Esta_Correto()
        {
            var actual = Ingrediente.Ovo();

            Assert.Equal("Ovo",actual.Nome);
            Assert.Equal(.8m,actual.Valor);
        }

        [Fact]
        public void Checar_Se_Queijo_Esta_Correto()
        {
            var actual = Ingrediente.Queijo();

            Assert.Equal("Queijo",actual.Nome);
            Assert.Equal(1.5m,actual.Valor);
        }
    }
}
