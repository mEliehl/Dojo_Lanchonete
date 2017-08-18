using System.Collections.Generic;

namespace Lanchonete
{
    public class Inflacao
    {
        public static Inflacao Instance;
        private ICollection<decimal> Percentagens = new List<decimal>();

        protected Inflacao()
        {

        }

        public static Inflacao GetInstance()
        {
            if(Instance == null)
                Instance = new Inflacao();

            return Instance;
        }

        public void AdicionarInflacao(uint percentagem)
        {
            this.Percentagens.Add(percentagem);
        }

        //
        public void LimparInflacao()
        {
            this.Percentagens.Clear();
        }

        public IEnumerable<decimal> GetInflacao()
        {
            return this.Percentagens;
        }
    }
}