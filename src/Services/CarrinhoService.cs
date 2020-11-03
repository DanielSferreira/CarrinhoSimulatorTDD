using System.Linq;
using Models;

namespace src.Services
{
    public class CarrinhoService
    {
        public CarrinhoModel data;

        public CarrinhoService()
        {
            data = new CarrinhoModel();
        }

        public bool AddToCarrinho(ProdutoModel prd)
        {
            try
            {
                data.ListaProduto.Add(prd);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public double UpdatePreco()
        {
            data.Total = data.ListaProduto.Sum(x=> x.Preco);
            return data.Total;
        }
        public bool FinalizaCompra()
        {
            int QuantItens = data.ListaProduto.Count;
            double Total = data.Total;
            
            if( QuantItens >= 0 || Total >= 0) return true;
            else return false;
        }
    }
}