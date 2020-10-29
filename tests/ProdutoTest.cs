using FluentAssertions;
using Xunit;

using Services;

namespace tests
{
    public class ProdutoTest
    {
        Produto prd;
        public ProdutoTest() =>
            this.prd = new Produto();
        
        [Fact]
        public void ProdutosNaoVazios() => 
            prd.Produtos().
    }
}
            
