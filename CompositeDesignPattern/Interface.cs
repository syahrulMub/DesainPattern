namespace CompositeDesignPattern;

public interface IRobotComponent
{
    public void Detail();
    public string GetName();
}

public interface ICommand
{
    public void Execute();
}

public interface ISernsorObserver
{

}
