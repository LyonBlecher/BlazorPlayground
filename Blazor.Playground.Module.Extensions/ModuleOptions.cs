using Blazor.Playground.Modules;
using System.Reflection;

namespace Blazor.Playground.Module.Extensions
{
    internal class ModuleOptions : IModuleOptions, IAddModuleOptions
    {
        private List<IModule> _modules = new();
        private Dictionary<Type, IModuleMenu> _moduleMenus = new();

        public IAddModuleOptions AddModule<T>()
            where T : IModule, new()
        {
            _modules.Add(new T());

            return this;
        }

        internal void AddModuleMenu(IModule module, ModuleMenu moduleMenu)
        {
            _moduleMenus.Add(module.GetType(), moduleMenu);
        }

        public IReadOnlyCollection<IModule> Modules => _modules;

        public IReadOnlyCollection<Assembly> ModuleAssemblies => _modules.Select(_ => _.GetType().Assembly).ToList();

        public IEnumerable<IMenuItem> ModuleMenus => _moduleMenus
                                                        .SelectMany(_ => _.Value.Menu)
                                                            .OrderBy(_ => _.RelativePosition)
                                                                .AsEnumerable();
    }

    public class ApplicationOptions : IApplicationOptions, IAddApplicationOptionsBreadCrumbs
    {
        private List<IMenuItem> _internalBreadCrumbs = new();

        public string Name { get; set; } = "";

        public IReadOnlyCollection<IMenuItem> InternalBreadCrumbs =>_internalBreadCrumbs;

        public void AddBreadCrumb(IMenuItem item)
        {
            _internalBreadCrumbs.Add(item);
        }

        public void ClearBreadCrumbs()
        {
            _internalBreadCrumbs.Clear();
        }
    }
}