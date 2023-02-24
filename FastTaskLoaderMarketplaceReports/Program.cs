using FastTaskLoaderMarketplaceReports.Models;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

string jsonWbContent = File.ReadAllText("wbSellers.json");
List<ApiInfoModel> wbSellers = JsonSerializer.Deserialize<List<ApiInfoModel>>(jsonWbContent) ?? throw new NullReferenceException();

