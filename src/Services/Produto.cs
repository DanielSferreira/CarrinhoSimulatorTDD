using Models;
using System.Collections.Generic;
using System.Linq;
namespace Services
{
    public class Produto : ProdutoInitialize
    {
        public ProdutoModel[] produto {get;}
        public Produto(): base() =>
            produto = base.Produtos();

        public ProdutoModel GetProdutoByName(string name)
        {
            var prd = produto.Where(x => x.Produto == name).First();
            if (prd == null) return null;
            return prd;
        }

        public List<ProdutoModel> listPordutos() =>
            produto.ToList();

    }
}