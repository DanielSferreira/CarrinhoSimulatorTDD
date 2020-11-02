using FluentAssertions;
using Xunit;

using src.Services;

namespace tests
{
    public class ProdutoTest
    {
        Produto prd;
        public ProdutoTest() =>
            this.prd = new Produto();

        [Fact]
        public void ProdutosNaoVazios() {
            prd.produto.Should().HaveCountGreaterThan(0, "A lista não pode ser vazia");}
        
        [Theory]
        [InlineData("Torta de Maça")]
        public void GetProdutos(string name)  =>
                prd.GetProdutoByName(name).Produto.Should().Be(name, "os nomes precisam ser iguam");
            
    }
}