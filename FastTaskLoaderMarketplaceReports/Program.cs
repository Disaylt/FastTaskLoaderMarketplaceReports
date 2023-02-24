using FastTaskLoaderMarketplaceReports;
using FastTaskLoaderMarketplaceReports.Models;
using FastTaskLoaderMarketplaceReports.Models.Wb;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

string jsonWbContent = File.ReadAllText("wbSellers.json");
List<ApiInfoModel> wbSellers = JsonSerializer.Deserialize<List<ApiInfoModel>>(jsonWbContent) ?? throw new NullReferenceException();


foreach(var wbSeller in wbSellers)
{
    WbApiHandler wbApiHandler = new WbApiHandler(wbSeller.Token);
    List<WbStockModel> wbStocks = await wbApiHandler.GetStocks();
}
