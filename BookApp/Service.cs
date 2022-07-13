using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;



namespace BookApp
{
    public class Service
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<RootObject> GetData(string location)
        {
            var streamTask = client.GetStreamAsync(location);
            var root = await JsonSerializer.DeserializeAsync<RootObject>(await streamTask);
            return root;
        }
    }
}
