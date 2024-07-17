using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjetLamp.Components.Toolbox
{
    public class APICaller
    {
        private Uri APIUri;
        private bool CaseInsensitiveOption;

        public APICaller(string aPIUri, bool caseInsensitiveOption) 
        {
            APIUri = new Uri(aPIUri);
            CaseInsensitiveOption = caseInsensitiveOption;
        }

        public T? GetCall<T>(string endpoint)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = APIUri;

            var response = client.GetAsync(endpoint).Result;

            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = CaseInsensitiveOption
                };

                var responseContent = response.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<T>(responseContent, options);
            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);

                return default;
            }
        }

        public bool PostCall<T>(string endpoint, T obj)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = APIUri;

            var json = JsonSerializer.Serialize(obj);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = client.PostAsync(endpoint, content).Result;

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);
                return false;
            }
        }
    }
}
