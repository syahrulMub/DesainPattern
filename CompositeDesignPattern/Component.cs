namespace CompositeDesignPattern;

public class PartComponent : IRobotComponent
{
    private string _name;
    public PartComponent(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void Detail()
    {
        Console.WriteLine($"Part: {_name}");
    }
}

public class ParentComponent : IRobotComponent
{
    private string _name;
    private List<IRobotComponent> _components = new List<IRobotComponent>();
    public ParentComponent(string name)
    {
        _name = name;
    }
    public void AddComponent(IRobotComponent component)
    {
        _components.Add(component);
    }
    public void RemoveComponent(IRobotComponent component)
    {
        _components.Remove(component);
    }
    public string GetName()
    {
        return _name;
    }
    public void Detail()
    {
        Console.WriteLine($"Component: {_name}");
        foreach (var component in _components)
        {
            component.Detail();
        }
    }
}