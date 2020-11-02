using System.Collections.Generic;
using Models;

namespace src.Services
{
    public class LojaService
    {
        private ClienteModel cliente;
        private CarrinhoModel carrinho;
        private CarrinhoService _carrinho;
        private List<ProdutoModel> ListarProdutosNaLoja;
        private Produto produtos;

        public LojaService(
            ClientInit cliente,
            CarrinhoModel carrinho,
            Produto produto
        )
        {
            this.cliente = cliente.Cliente();
            this.carrinho = carrinho;
            this._carrinho = new CarrinhoService();
            this.ListarProdutosNaLoja = produto.listPordutos();
            this.produtos = new Produto();
        }

        public bool login(ClienteModel clt)
        {
            this.cliente = new ClientInit().Cliente();
            this.cliente.Estado = true;
            
            if(this.cliente.NomeCliente != "" || this.cliente.NomeCliente != null) 
                return true;
                
            return false;   
            
        }

        public bool logout()
        {
            this.cliente.Id = 0;
            this.cliente.NomeCliente = "";
            this.cliente.Estado = false;
            
            return this.cliente.Estado;
        }

        public bool LojaAddProdutoToCarrinho(string prdName)
        {
            try
            {
                var prod = this.produtos.GetProdutoByName(prdName);
                this._carrinho.AddToCarrinho(prod);
                return true;
            }
            catch (System.Exception)
            {
                return false;  
                throw;
            };
        }

    }
}