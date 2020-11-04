using System.IO;
using Models;
using Newtonsoft.Json;
namespace src.Services
{
    public class ClientInit
    {
        private ClienteModel clt;
        public ClientInit() =>
            this.clt = JsonConvert.DeserializeObject<ClienteModel>(File.ReadAllText(@"Models/json/cliente.json"));
        
        public ClienteModel Cliente() =>  clt;
    }
}