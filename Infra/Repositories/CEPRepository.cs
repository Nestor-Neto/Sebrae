using Domain.Entities;
using Domain.Repositories;
using Newtonsoft.Json;
using RestSharp;


namespace Infra.Repositories
{
    public class CEPRepository : ICEPRepository
    {
        public async Task<CEPDTO> GetCEP() 
        {
            var client = new RestClient("http://viacep.com.br/ws/01001000/json/");
            var request = new RestRequest("", Method.Get) { RequestFormat = DataFormat.Json };

            RestResponse response = client.Execute(request);
            var conteudo = response.Content;

            return JsonConvert.DeserializeObject<CEPDTO>(conteudo);
        }
    }
}
