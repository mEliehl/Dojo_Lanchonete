using System;
using Xunit;

namespace Lanchonete.Test
{
    [Collection("bootstrap")]
    public class InflacaoTest : IDisposable
    {
        readonly Inflacao inflacao;
        public InflacaoTest()
        {
            inflacao = Inflacao.GetInstance();
        }

        [Fact]
        public void Adicionar_Inflacao_E_Checar_Valores_Ingredientes()
        {
            inflacao.AdicionarInflacao(10);
            Assert.Equal(.44m, Ingrediente.Alface().Valor, 2);
            Assert.Equal(2.2m, Ingrediente.Bacon().Valor, 2);
            Assert.Equal(3.3m, Ingrediente.HamburgerCarne().Valor, 2);
            Assert.Equal(.88m, Ingrediente.Ovo().Valor, 2);
            Assert.Equal(1.65m, Ingrediente.Queijo().Valor, 2);
        }

        [Fact]
        public void Adicionar_Inflacao_Duas_Vezes_E_Checar_Valores_Ingredientes()
        {
            inflacao.AdicionarInflacao(10);
            inflacao.AdicionarInflacao(10);
            Assert.Equal(.48m, Ingrediente.Alface().Valor, 2);
            Assert.Equal(2.42m, Ingrediente.Bacon().Valor, 2);
            Assert.Equal(3.63m, Ingrediente.HamburgerCarne().Valor, 2);
            Assert.Equal(.97m, Ingrediente.Ovo().Valor, 2);
            Assert.Equal(1.82m, Ingrediente.Queijo().Valor, 2);
        }

        [Fact]
        public void Adicionar_Inflacao_E_Criar_XBurger()
        {
            inflacao.AdicionarInflacao(10);
            var lanche = new XBurger();

            Assert.Equal(4.95m, lanche.Total(), 2);
        }

        void IDisposable.Dispose()
        {
            inflacao.LimparInflacao();
        }
    }
}