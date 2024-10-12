namespace ChainofResponsibility;

public interface IPositionHandler
{
    void nextHandler(PositionHandler positionHandler);
    void HandleRequest(int money);
}

public abstract class PositionHandler : IPositionHandler
{
    protected IPositionHandler _nextHandler;
    public void nextHandler(PositionHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }
    public abstract void HandleRequest(int money);
}