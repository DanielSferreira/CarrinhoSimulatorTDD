using System;
using Xunit;

using Services;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ProdutoInitialize prd = new ProdutoInitialize("produtos");
            Assert.Equal(prd.Produtos()[0].Preco, (double)150.00);
        }
    }
}
