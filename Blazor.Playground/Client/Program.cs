using Blazor.Playground;
using Blazor.Playground.Counter;
using Blazor.Playground.FetchData;
using Blazor.Playground.Module.Extensions;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

namespace Blazor.Playground
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddMudServices();

            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddModules(
                applicationOptions =>
                {
                    applicationOptions.Name = "Blazor Playground";
                }, 
                moduleOption =>
                {
                    moduleOption
                        .AddModule<CounterModule>()
                        .AddModule<FetchDataModule>();
                });

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            var host = builder.Build();

            host.UseModules();

            await host.RunAsync();
        }
    }
}