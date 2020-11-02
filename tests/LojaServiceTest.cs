using Xunit;
using static Xunit.Assert;
using FluentAssertions;
using Services;
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
        public void TestName()
        {
            
        }
    }
}