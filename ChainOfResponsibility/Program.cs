using System.Collections.Generic;
using ChainofResponsibility;
public class Program
{
    static void Main(string[] args)
    {
        int requestBudget = 700000000;
        PositionHandler manager = new Manager();
        PositionHandler director = new Director();
        PositionHandler CEO = new CEO();

        manager.nextHandler(director);
        director.nextHandler(CEO);

        Console.WriteLine("sending requst event" + requestBudget);
        manager.HandleRequest(requestBudget);
    }
}