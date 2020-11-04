using System.IO;
using Models;
using Newtonsoft.Json;
namespace src.Services
{
    public class ProdutoInitialize
    {
        private ProdutoModel[] _produtos;
        public ProdutoInitialize() =>
            _produtos = JsonConvert.DeserializeObject<ProdutoModel[]>(File.ReadAllText("Models/json/produtos.json"));
        
        public ProdutoModel[] Produtos() =>  _produtos;
    }
}