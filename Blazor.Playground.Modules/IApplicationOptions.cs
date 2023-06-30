namespace Blazor.Playground.Modules
{
    public interface IApplicationOptions
    {
        string Name { get; set; }

        IReadOnlyCollection<IMenuItem> InternalBreadCrumbs { get; }
    }

    public interface IAddApplicationOptionsBreadCrumbs
    {
        void AddBreadCrumb(IMenuItem item);

        void ClearBreadCrumbs();
    }
}
