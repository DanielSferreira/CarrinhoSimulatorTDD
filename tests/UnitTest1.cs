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
            ProdutoInitialize prd = new ProdutoInitialize();
            Console.WriteLine(prd.test.nome);
        }
    }
}
