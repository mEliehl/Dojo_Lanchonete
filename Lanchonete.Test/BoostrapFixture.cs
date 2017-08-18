using Xunit;

namespace Lanchonete.Test
{
    public class BoostrapFixture
    {
        public BoostrapFixture()
        {
            BootstrapLanchonete.Start();
        }
    }

    [CollectionDefinition("bootstrap")]
    public class BoostrapFixtureTest : ICollectionFixture<BoostrapFixture>
    {
        
    }
}