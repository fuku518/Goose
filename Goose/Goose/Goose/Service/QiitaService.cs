using Goose.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Goose.Service
{
    public class QiitaService
    {
        private static string BaseUri { get; } = "https://qiita.com/api/v2/";

        private static string GetApiUri(string apiName)
        {
            return $"{BaseUri}{apiName}";
        }

        public static async Task<IEnumerable<Item>> GetItemsAsync()
        {
            var uri = GetApiUri("items");
            using (var hc = new HttpClient())
            {
                var json = await hc.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<Item[]>(json);
            }
        }
    }
}
