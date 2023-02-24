using FastTaskLoaderMarketplaceReports.Models;
using FastTaskLoaderMarketplaceReports.Models.Wb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace FastTaskLoaderMarketplaceReports
{
    internal class WbApiHandler
    {
        private readonly string _token;
        public WbApiHandler(string token)
        {
            _token = token;
        }

        public async Task<List<WbStockModel>> GetStocks()
        {
            using(var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Get, "https://statistics-api.wildberries.ru/api/v1/supplier/stocks"))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue(_token);
                    var response = await client.SendAsync(request);
                    List<WbStockModel> wbStocks = await response.Content.ReadFromJsonAsync<List<WbStockModel>>() ?? throw new NullReferenceException();

                    return wbStocks;
                }
            }
        }
    }
}
