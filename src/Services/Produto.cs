using Models;
using System.Linq;
namespace Services
{
    public class Produto : ProdutoInitialize
    {
        public ProdutoModel[] produto {get;}
        public Produto(): base()
        {produto = base.Produtos();}

        public ProdutoModel GetProdutoByName(string name)
        {
            return produto.Where(x => x.Produto == name).First();
        }

    }
}