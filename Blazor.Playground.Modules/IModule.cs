using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.Playground.Modules
{
    public interface IModule
    {
        void ConfigureServices(IServiceCollection services);

        void RegisterApplication(WebAssemblyHost host);

        void DefineMenu(IModuleMenu menu);
    }
}