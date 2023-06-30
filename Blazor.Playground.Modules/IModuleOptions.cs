using System.Reflection;

namespace Blazor.Playground.Modules
{
    public interface IModuleOptions : IModuleMenuOptions
    {
        IReadOnlyCollection<IModule> Modules { get; }

        IReadOnlyCollection<Assembly> ModuleAssemblies { get; }
    }

    public interface IModuleMenuOptions
    {
        public IEnumerable<IMenuItem> ModuleMenus { get; }
    }
}
