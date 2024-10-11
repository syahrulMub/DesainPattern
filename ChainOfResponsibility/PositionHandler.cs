namespace ChainofResponsibility;

public interface IPositionHandler
{
    void nextHandler(PositionHandler positionHandler);
}

public abstract class PositionHandler : IPositionHandler
{
    protected PositionHandler _nextHandler;
    public void nextHandler(PositionHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }
    public abstract void HandleRequest(int money);
}