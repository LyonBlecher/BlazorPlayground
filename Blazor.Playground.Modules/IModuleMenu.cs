namespace Blazor.Playground.Modules
{
    public interface IModuleMenu
    {
        IModuleMenu AddMenuItem(IMenuItem menuItem);

        IModuleMenu AddMenuItems(params IMenuItem[] menuItems);

        IReadOnlyCollection<IMenuItem> Menu { get; }
    }
}