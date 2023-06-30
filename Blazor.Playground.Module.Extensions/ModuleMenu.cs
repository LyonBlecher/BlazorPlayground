using Blazor.Playground.Modules;

namespace Blazor.Playground.Module.Extensions
{
    public class ModuleMenu : IModuleMenu
    {
        private List<IMenuItem> _menuItems = new();

        public IModuleMenu AddMenuItem(IMenuItem menuItem)
        {
            _menuItems.Add(menuItem);

            return this;
        }

        public IModuleMenu AddMenuItems(params IMenuItem[] menuItems)
        {
            _menuItems.AddRange(menuItems);

            return this;
        }

        public IReadOnlyCollection<IMenuItem> Menu => _menuItems;
    }
}