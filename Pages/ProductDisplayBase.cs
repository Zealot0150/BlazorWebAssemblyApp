using Microsoft.AspNetCore.Components;
using ShopModel.Dtos;

namespace BlazorWebAssemblyApp.Pages
{
    public class ProductDisplayBase:ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
