using System;

namespace Lanchonete
{
    public class Ingrediente : IEquatable<Ingrediente>
    {
        private Ingrediente(string nome, decimal valor)
        {
            this.Nome = nome;
            this._Valor = valor;

        }
        public string Nome { get; private set; }

        // public decimal Valor { get; private set; }
        private decimal _Valor { get; set; }
        public decimal Valor
        {
            get
            {
                var retorno = _Valor;
                var inflacao = Inflacao.GetInstance().GetInflacao();
                foreach(var percentagem in inflacao)
                    retorno += (retorno * percentagem) / 100;
                return retorno;
            }
        }

        public static Ingrediente Alface() => new Ingrediente("Alface", 0.4m);
        public static Ingrediente Bacon() => new Ingrediente("Bacon", 2m);
        public static Ingrediente HamburgerCarne() => new Ingrediente("Hambúrguer de carne", 3);
        public static Ingrediente Ovo() => new Ingrediente("Ovo", 0.8m);
        public static Ingrediente Queijo() => new Ingrediente("Queijo", 1.5m);

        public bool Equals(Ingrediente other)
        {
            return this.Nome == other.Nome;
        }
    }
}