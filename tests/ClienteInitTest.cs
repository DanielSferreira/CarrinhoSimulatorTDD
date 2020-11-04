using FluentAssertions;
using Xunit;

using src.Services;

namespace tests
{
    public class ClienteInitTest
    {
        public ClientInit clt;
        public ClienteInitTest() =>
            this.clt = new ClientInit();
        
        [Fact]
        public void ProdutosNaoVazios() => 
            this.clt.Cliente().Should().NotBeNull("A lista não pode ser vázia");
        
        [Fact]
        public void ProdutosTemQueSerProdutosModelsType() =>
            this.clt.Cliente().Should().BeOfType<Models.ClienteModel>("Tem que ser Tipo Models");
    }
}
            
