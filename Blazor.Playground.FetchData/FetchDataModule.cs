using Blazor.Playground.Modules;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor;

namespace Blazor.Playground.FetchData
{
    public class FetchDataModule : Module
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            Console.WriteLine("---------------------------Services-----------------------------");
        }

        public override void RegisterApplication(WebAssemblyHost host)
        {
            Console.WriteLine("---------------------------App-----------------------------");
        }

        public override void DefineMenu(IModuleMenu menu)
        {
            menu.AddMenuItem(new MenuItem(Guid.Parse("226a7a75-3f60-424e-8a61-1767567b0c81"), 1, "Fetch Data", "fetchdata", Icons.Material.Filled.Handshake));
        }
    }
}
