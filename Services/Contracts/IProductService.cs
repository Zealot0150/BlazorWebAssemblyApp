using ShopModel.Dtos;

namespace BlazorWebAssemblyApp.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
