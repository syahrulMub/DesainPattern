namespace CompositeDesignPattern;

public class MovementComponent
{
    private IRobotComponent _component;
    public MovementComponent(IRobotComponent component)
    {
        _component = component;
    }
    public void Move()
    {
        Console.WriteLine($"Moving {_component.GetName()}");
    }
    public void Stop()
    {
        Console.WriteLine($"Stopping {_component.GetName()}");
    }
}

public class RemoverComponent
{
    private IRobotComponent _component;
    public RemoverComponent(IRobotComponent component)
    {
        _component = component;
    }
    public void Remove()
    {
        Console.WriteLine($"{_component.GetName()} Removing");
    }
    public void Complete()
    {
        Console.WriteLine($"{_component.GetName()} Complete removing");
    }
}

public class MoveRobot : ICommand
{
    private MovementComponent _movementComponent;
    public MoveRobot(MovementComponent movementComponent)
    {
        _movementComponent = movementComponent;
    }
    public void Execute()
    {
        _movementComponent.Move();
    }
}
public class StopRobot : ICommand
{
    private MovementComponent _movementComponent;
    public StopRobot(MovementComponent movementComponent)
    {
        _movementComponent = movementComponent;
    }
    public void Execute()
    {
        _movementComponent.Stop();
    }
}
