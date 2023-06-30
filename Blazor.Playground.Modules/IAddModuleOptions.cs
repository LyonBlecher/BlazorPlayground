namespace Blazor.Playground.Modules
{
    public interface IAddModuleOptions
    {
        IAddModuleOptions AddModule<T>()
            where T : IModule, new();
    }
}
