namespace Plugin
{

    /// Plugin v1.0
    public interface IPluginInterface
    {
        string Name { get; }
        string Ver { get; }
        string Action(string[] args);
    }
}
