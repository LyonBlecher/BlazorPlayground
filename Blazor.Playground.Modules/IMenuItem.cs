namespace Blazor.Playground.Modules
{
    public interface IMenuItem
    {
        Guid Id { get; init; }
        int RelativePosition { get; init; }
        string Text { get; init; }
        string Icon { get; init; }
    }

    public interface IMenuGroup : IMenuItem
    {
        MenuItem AddChild(MenuItem menuItem);
    }
}