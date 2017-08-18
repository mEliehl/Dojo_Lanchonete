namespace Lanchonete.Descontos
{
    public interface IDesconto
    {
         decimal ValorDesconto(Lanche lanche,decimal Total);
    }
}