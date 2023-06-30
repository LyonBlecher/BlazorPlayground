using Blazor.Playground.Modules;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor.Playground.Module.Extensions
{
    public static class ModuleRegisterationExtensions
    {
        public static IServiceCollection AddModules(this IServiceCollection services, Action<IApplicationOptions> application, Action<IAddModuleOptions> modules)
        {
            ApplicationOptions applicationOptions = new();
            ModuleOptions moduleOptions = new();

            modules(moduleOptions);
            application(applicationOptions);

            foreach (var module in moduleOptions.Modules)
            {
                module.ConfigureServices(services);

                ModuleMenu moduleMenu = new();

                module.DefineMenu(moduleMenu);

                moduleOptions.AddModuleMenu(module, moduleMenu);
            }

            services.AddSingleton<IModuleOptions>(sp => moduleOptions);
            services.AddSingleton<IApplicationOptions>(sp => applicationOptions);
            services.AddSingleton<IAddApplicationOptionsBreadCrumbs>(sp => applicationOptions);

            return services;
        }

        public static WebAssemblyHost UseModules(this WebAssemblyHost host)
        {
            var modules = host.Services.GetRequiredService<IModuleOptions>();

            foreach (var module in modules.Modules)
            {
                module.RegisterApplication(host);
            }

            return host;
        }
    }

    
}