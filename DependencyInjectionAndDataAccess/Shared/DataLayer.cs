using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace DependencyInjectionAndDataAccess.Shared
{
    public class DataLayer : IDataLayer
    {
        HttpClient _httpClient;

        public DataLayer(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> FetchProductsAsync(string sortField, bool isAsc)
        {
            var url = $"https://services.odata.org/V3/(S(xslbzbuxbd0ssc2wwcnn1ret))/OData/OData.svc/Products?$format=json&$orderby={sortField} {(isAsc ? "asc" : "desc")}";
            var res = await _httpClient.GetJsonAsync<Data>(url);
            return res.value;
        }

        public async Task<Product> GetProductById(int id)
        {
            var url = $"https://services.odata.org/V3/(S(xslbzbuxbd0ssc2wwcnn1ret))/OData/OData.svc/Products?$filter=ID eq {id}&$format=json";
            var res = await _httpClient.GetJsonAsync<Data>(url);
            return res.value[0];
        }
    }
}
