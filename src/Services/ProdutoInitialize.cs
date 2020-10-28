using System.IO;
using Models;
using Newtonsoft.Json;
namespace Services
{
    public class ProdutoInitialize
    {
        private ProdutoModel[] _produtos;
        public ProdutoInitialize() =>
            _produtos = JsonConvert.DeserializeObject<ProdutoModel[]>(File.ReadAllText(@"/home/dan/Documentos/json/produtos.json"));
        public ProdutoInitialize(string local) =>
            _produtos = JsonConvert.DeserializeObject<ProdutoModel[]>(File.ReadAllText($"/home/dan/Documentos/json/{local}.json"));
        
        public ProdutoModel[] Produtos() =>  _produtos;
    }
}