using Xunit;
using FluentAssertions;
using src.Services;
using Moq;

namespace tests
{
    public class LojaServiceTest
    {
        [Fact]
        [Trait("Init","loginTest")]
        public void loginTest()
        {
            var m_clt = new Mock<ClientInit>();
            var m_car = new Mock<Models.CarrinhoModel>();
            var m_prd = new Mock<Produto>();
            
            var clt =new LojaService(m_clt.Object,m_car.Object,m_prd.Object).login(m_clt.Object.Cliente());
            clt.Should().BeTrue("o login deve retornar verdadeiro");
        }

        [Fact]
        public void logoutTest()
        {
            var m_clt = new Mock<ClientInit>();
            var m_car = new Mock<Models.CarrinhoModel>();
            var m_prd = new Mock<Produto>();
            
            var clt = new LojaService(m_clt.Object,m_car.Object,m_prd.Object).logout();
            clt.Should().BeFalse("o logout deve retornar falso");
        }
        [Fact]
        public void  LojaAddProdutoToCarrinhoTest_Verifica()
        {
            var m_clt = new Mock<ClientInit>();
            var m_car = new Mock<Models.CarrinhoModel>();
            var m_prd = new Mock<Produto>();
            
            var loja = new LojaService(m_clt.Object,m_car.Object,m_prd.Object);
            bool except = loja.LojaAddProdutoToCarrinho("Torta de Maça");
            except.Should().BeTrue("a função deve retornar verdadeiro");           
        }
    }
}