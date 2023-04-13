using BlazorWebAssemblyApp.Services.Contracts;
using ShopModel.Dtos;
using System.Net.Http.Json;


namespace BlazorWebAssemblyApp.Services
{
    public class ProductService: IProductService
    {
        private readonly HttpClient _client;

        public ProductService(HttpClient client)
        {
            this._client = client;
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            try
            {
                return await _client.GetFromJsonAsync < IEnumerable<ProductDto>>($"api/Product");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
