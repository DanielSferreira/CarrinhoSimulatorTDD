using System.Collections.Generic;
namespace Models
{
    public class CarrinhoModel {
        public string NomeCliente {get; set;}
        public List<ProdutoModel> ListaProduto {get; set;}
        public double Total {get; set;}

        public CarrinhoModel()
        {
            ListaProduto = new List<ProdutoModel>();
        }
    }
}