using Lanchonete.Descontos;

namespace Lanchonete
{
    public class BootstrapLanchonete
    {
        private static bool IsStarted;
        public static void Start()
        {
            if(!IsStarted)
            {
                IsStarted = true;
                var descontos = ListaDeDescontoProxy.GetInstance();

                descontos.AdicionarDesconto(new MuitaCarne());
                descontos.AdicionarDesconto(new MuitoQueijo());
                descontos.AdicionarDesconto(new SejaLight());
                
            }
        }
    }
}