using FluentAssertions;
using Xunit;

using src.Services;

namespace tests
{
    public class ProdutoInitTest
    {
        ProdutoInitialize prd;
        public ProdutoInitTest() =>
            this.prd = new ProdutoInitialize("produtos");
        
        [Fact]
        public void ProdutosNaoVazios() => 
            prd.Produtos().Should().HaveCountGreaterThan(0,"A lista não pode ser vázia");
        
        [Fact]
        public void ProdutosTemQueSerProdutosModelsType() =>
            this.prd.Produtos().Should().AllBeOfType<Models.ProdutoModel>("Tem que ser Tipo Models");
    }
}
            
