using Blazor.Playground.Modules;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor;

namespace Blazor.Playground.Counter
{
    public class CounterModule : Module
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
            var counterMenuItem = 
                new MenuGroup(Guid.Parse("8380e311-c864-4a89-9174-1abefaa4be1f"), 0, "User Management", Icons.Material.Filled.People)
                    .AddChild(new MenuItem(Guid.Parse("c9f0e932-45aa-4b8d-b7f6-3f0704b8b508"), 0, "Manage Users", "child1", Icons.Material.Filled.Person))
                    .AddChild(new MenuItem(Guid.Parse("b37998bc-1c68-4c84-96fb-f0c9e22cfa2e"), 1, "Manage Roles", "counter", Icons.Material.Filled.SupervisedUserCircle))
                    .AddChild(new MenuItem(Guid.Parse("b37998bc-1c68-4c84-96fb-f0c9e22cfa2f"), 1, "Expandable Grid test", "expand", Icons.Material.Filled.Explore));

            menu.AddMenuItems(counterMenuItem);
        }
    }
}
