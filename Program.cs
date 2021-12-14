using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using IgniteUI.Blazor.Controls;
using EcommerceAutoShop;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(typeof(IgbButtonModule));
    services.AddIgniteUIBlazor(typeof(IgbRippleModule));
    services.AddIgniteUIBlazor(typeof(IgbIconModule));
    services.AddIgniteUIBlazor(typeof(IgbCardModule));
    services.AddIgniteUIBlazor(typeof(IgbListModule));
    services.AddIgniteUIBlazor(typeof(IgbBadgeModule));
    services.AddIgniteUIBlazor(typeof(IgbAvatarModule));
}