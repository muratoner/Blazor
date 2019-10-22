using System.Collections.Generic;
using System.Threading.Tasks;

namespace DependencyInjectionAndDataAccess.Shared
{
    interface IDataLayer
    {
        Task<List<Product>> FetchProductsAsync(string sortField, bool filter);
        Task<Product> GetProductById(int id);
    }
}
