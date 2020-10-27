using System.Collections.Generic;
namespace Models
{
    public class LojaModel {
        public string NomeCliente {get; set;}
        public List<ProdutoModel> ListaProduto {get; set;}
        public double Total {get; set;}
    }
}