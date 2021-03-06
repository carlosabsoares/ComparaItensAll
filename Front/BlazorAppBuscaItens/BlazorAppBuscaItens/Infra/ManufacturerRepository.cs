using BlazorAppBuscaItens.Infra.Interface;
using BlazorAppBuscaItens.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BlazorAppBuscaItens.Infra
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private HttpClient client = new HttpClient();
        private string url = @"https://localhost:44324/v1/comparaItens/manufacturer/";

        public ManufacturerRepository()
        {
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
        }

        public async Task<IList<Manufacturer>> GetAll()
        {
            HttpResponseMessage response = await client.GetAsync(url + "findAll");

            var list = new List<Manufacturer>();

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                list = JsonConvert.DeserializeObject<List<Manufacturer>>(data);
            }

            return list;
        }

        public async Task<Manufacturer> GetById(int id)
        {
            HttpResponseMessage response = await client.GetAsync(url + "findById?id=" + id);

            var list = new Manufacturer();

            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                list = JsonConvert.DeserializeObject<Manufacturer>(data);
            }

            return list;
        }

        public async Task<bool> Add(Manufacturer manufacturer)
        {
            using (var client = new HttpClient())
            {
                var dict = new Dictionary<string, string>();

                dict.Add("description", manufacturer.Description);

                var req = new HttpRequestMessage(HttpMethod.Post, (url + "create"))
                {
                    Content = new FormUrlEncodedContent(dict)
                };

                var response = await client.SendAsync(req);

                bool _success;

                _success = false;

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    _success = JsonConvert.DeserializeObject<bool>(data);
                }

                return _success;
            }
        }

        public Task<bool> Remove(Manufacturer manufacturer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Manufacturer manufacturer)
        {
            throw new NotImplementedException();
        }
    }
}