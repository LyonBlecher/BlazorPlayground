using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.Playground.Modules
{
    public abstract class Module : IModule
    {
        public virtual void ConfigureServices(IServiceCollection services)
        {
            return;
        }

        public virtual void RegisterApplication(WebAssemblyHost host)
        {
            return;
        }

        public virtual void DefineMenu(IModuleMenu menu)
        {
            return;
        }
    }
}
