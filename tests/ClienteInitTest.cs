using FluentAssertions;
using Xunit;

using src.Services;

namespace tests
{
    public class ClienteInitTest
    {
        ProdutoInitialize prd;
        public ClienteInitTest() =>
            this.prd = new ProdutoInitialize("produtos");
        
        [Fact]
        public void ProdutosNaoVazios() => 
            prd.Produtos().Should().HaveCountGreaterThan(0,"A lista não pode ser vázia");
        
        [Fact]
        public void ProdutosTemQueSerProdutosModelsType() =>
            this.prd.Produtos().Should().AllBeOfType<Models.ProdutoModel>("Tem que ser Tipo Models");
    }
}
            
