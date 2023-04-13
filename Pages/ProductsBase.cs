using BlazorWebAssemblyApp.Services.Contracts;
using Microsoft.AspNetCore.Components;
using ShopModel.Dtos;

namespace BlazorWebAssemblyApp.Pages
{
    public class ProductsBase:ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }

        public IEnumerable<ProductDto> Products { get; set;}

        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetProducts();
            

        }
    }
}
