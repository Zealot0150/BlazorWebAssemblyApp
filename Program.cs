using BlazorWebAssemblyApp;
using BlazorWebAssemblyApp.Services;
using BlazorWebAssemblyApp.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7264/") });
builder.Services.AddScoped<IProductService, ProductService>();

await builder.Build().RunAsync();
