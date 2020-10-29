using System.IO;
using Models;
using Newtonsoft.Json;
namespace Services
{
    public class ClientInit
    {
        private ClienteModel clt;
        public ClientInit() =>
            this.clt = JsonConvert.DeserializeObject<ClienteModel>(File.ReadAllText(@"/home/dan/Documentos/json/cliente.json"));
        
        public ClienteModel Cliente() =>  clt;
    }
}