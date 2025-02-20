namespace CompositeDesignPattern;

public class MovementComponent
{
    private IRobotComponent _component;
    private int _currentPointIndex;
    public MovementComponent(IRobotComponent component)
    {
        _component = component;
        _currentPointIndex = 0;
    }
    public void Move()
    {
        Console.WriteLine($"Moving {_component.GetName()} from {_currentPointIndex}");
    }
    public void Stop()
    {
        Console.WriteLine($"Stopping {_component.GetName()} at {_currentPointIndex}");
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

public class RobotController
{
    private ICommand _moveCommand;
    private ICommand _stopCommand;
    public RobotController(ICommand moveCommand, ICommand stopCommand)
    {
        _moveCommand = moveCommand;
        _stopCommand = stopCommand;
    }
    public void Move()
    {
        _moveCommand.Execute();
    }
    public void Stop()
    {
        _stopCommand.Execute();
    }
}

public class Track
{
    public List<string> _point;
    private int _trackLenght;
    public Track(int trackLenght)
    {
        _point = [];
        _trackLenght = trackLenght;
    }
    public void AddPoint(string point)
    {
        _point.Add(point);
    }
}