using System.IO;
using Models;
using Newtonsoft.Json;
namespace Services
{
    public class Tester
    {
        public string nome {get; set;}
        public string acesso {get; set;}
    }
    public class ProdutoInitialize
    {
        private ProdutoModel _produto {get; set;}
        public Tester test;

        public ProdutoInitialize()
        {
            this.test = JsonConvert.DeserializeObject<Tester>(File.ReadAllText(@"/home/dan/Documentos/json/test.json"));
        }
    }
}