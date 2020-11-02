using System.Linq;
using Models;

namespace src.Services
{
    public class CarrinhoService
    {
        protected CarrinhoModel _carrinho;

        public CarrinhoService()
        {
            _carrinho = new CarrinhoModel();
        }

        public bool AddToCarrinho(ProdutoModel prd)
        {
            try
            {
                _carrinho.ListaProduto.Add(prd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public double UpdateCarrinho()
        {
            _carrinho.Total = _carrinho.ListaProduto.Sum(x=> x.Preco);
            return _carrinho.Total;
        }
    }
}