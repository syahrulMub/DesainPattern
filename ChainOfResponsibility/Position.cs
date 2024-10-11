
namespace ChainofResponsibility;

public class Manager : PositionHandler
{
    public override void HandleRequest(int money)
    {
        if (money < 10000000)
        {
            Console.WriteLine("Manager approved the request.");
        }
        else if (money >= 1000000 && _nextHandler != null)
        {
            Console.WriteLine("Manager can't accept the request.");
            _nextHandler.HandleRequest(money);
        }
        else if (money >= 1000000 && _nextHandler == null)
        {
            Console.WriteLine("Request rejected.");
        }
    }
}

public class Director : PositionHandler
{
    public override void HandleRequest(int money)
    {
        if (money < 50000000)
        {
            Console.WriteLine("Director approved the request.");
            Console.WriteLine("This is terms and condition with budget " + money);
        }
        else if (money >= 50000000 && _nextHandler != null)
        {
            Console.WriteLine("Director can't accept the request.");
            _nextHandler.HandleRequest(money);
        }
        else if (money >= 50000000 && _nextHandler == null)
        {
            Console.WriteLine("Request rejected.");
        }
    }
}

public class CEO : PositionHandler
{
    public override void HandleRequest(int money)
    {
        if (money < 100000000)
        {
            Console.WriteLine("CEO approved the request.");
            Console.WriteLine("This is terms and condition with budget " + money);
        }
        else if (money >= 100000000 && _nextHandler != null)
        {
            Console.WriteLine("CEO can't accept the request.");
            _nextHandler.HandleRequest(money);
        }
        else if (money >= 100000000 && _nextHandler == null)
        {
            Console.WriteLine("Request rejected.");
        }
    }
}