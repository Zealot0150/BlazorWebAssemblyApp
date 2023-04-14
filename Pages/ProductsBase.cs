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

        protected IOrderedEnumerable<IGrouping<int, ProductDto>> GetGroupedProductCatDtos()
        {
            return from p in Products
                                      group p by p.CategoryId into pOrderByCat
                                      orderby pOrderByCat.Key
                                      select pOrderByCat;
        }
        protected string GetCategoryName(IGrouping<int,ProductDto> groupedProductDtos)
        {
            return groupedProductDtos.FirstOrDefault(p => p.CategoryId == groupedProductDtos.Key).CategoryName;
        
        }

    }
}
