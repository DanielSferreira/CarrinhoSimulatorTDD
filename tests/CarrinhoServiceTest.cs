using Xunit;
using FluentAssertions;
using src.Services;
using Bogus;

namespace tests
{
    public class CarrinhoServiceTest
    {
        public CarrinhoService carrinho;
        public CarrinhoServiceTest()
        {
            carrinho = new CarrinhoService();
        }
        [Fact]
        public void AddToCarrinhoTest_VerificaSeRealmenteFoiAdicionado()
        {
            var prd = new Produto().GetProdutoByName("Torta de Maça");
            bool verify = carrinho.AddToCarrinho(prd);
            verify.Should().BeTrue("Precisa Adicionar um produto correto ao carrinho");
        }

        [Fact]
        public void UpdatePrecoTest_GaranteSoma()
        {
            //arrage
            var prd1 = new Produto().GetProdutoByName("Torta de Maça");
            var prd2 = new Produto().GetProdutoByName("Torta de Abobora");
            carrinho.AddToCarrinho(prd1);
            carrinho.AddToCarrinho(prd2);

            double execpt = 285.00;
            carrinho.UpdatePreco().Should().Be(execpt,"Precisa Adicionar um produto correto ao carrinho");
        }
        [Fact]
        public void UpdatePrecoTest_GaranteSomaPositiva()
        {
            //arrage
            var prd1 = new Produto().GetProdutoByName("Torta de Maça");
            var prd2 = new Produto().GetProdutoByName("Torta de Abobora");
            carrinho.AddToCarrinho(prd1);
            carrinho.AddToCarrinho(prd2);
            carrinho.UpdatePreco().Should().BePositive("Precisa Adicionar um produto correto ao carrinho");
        }
        [Fact]
        public void FinalizaCompraTest()
        {
            var prd1 = new Produto().GetProdutoByName("Torta de Maça");
            carrinho.AddToCarrinho(prd1);
            carrinho.FinalizaCompra().Should().BeTrue("Precisa Adicionar um produto correto ao carrinho");
        }
    }
} 