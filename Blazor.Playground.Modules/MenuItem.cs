namespace Blazor.Playground.Modules
{
    public record class MenuItem(Guid Id, int RelativePosition, string Text, string Route, string Icon) : IMenuItem;

    public record class MenuGroup(Guid Id, int RelativePosition, string Text, string Icon) : IMenuItem
    {
        private List<MenuItem> _children = new();

        public MenuGroup AddChild(MenuItem menuItem)
        {
            _children.Add(menuItem);

            return this;
        }

        public IReadOnlyCollection<MenuItem> Children => _children.OrderBy(_ => RelativePosition).ToList();
    }
}
