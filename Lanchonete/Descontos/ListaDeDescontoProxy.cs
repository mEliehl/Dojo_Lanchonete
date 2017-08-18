using System.Collections.Generic;

namespace Lanchonete.Descontos
{
    public class ListaDeDescontoProxy
    {
        private static ListaDeDescontoProxy Instance;
        private ICollection<IDesconto> Descontos = new List<IDesconto>();

        protected ListaDeDescontoProxy(){

        }

        public static ListaDeDescontoProxy GetInstance(){
            if(Instance == null)
                Instance = new ListaDeDescontoProxy();

            return Instance;
        }
        
        public void AdicionarDesconto(IDesconto desconto)
        {
            this.Descontos.Add(desconto);
        }

        public IEnumerable<IDesconto> GetDescontos(){
            return Descontos;
        }
    }
}