using System.Collections.Generic;
using Models;

namespace Services
{
    public class LojaService
    {
        private ClienteModel cliente;
        private CarrinhoModel carrinho;
        private List<Models.ProdutoModel> ListarProdutosNaLoja;

        public LojaService(
            ClientInit cliente,
            CarrinhoModel carrinho,
            Produto produto
        )
        {
            this.cliente = cliente.Cliente();
            this.carrinho = carrinho;
            this.ListarProdutosNaLoja = produto.listPordutos();
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



    }
}