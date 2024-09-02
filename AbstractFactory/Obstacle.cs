namespace GameFactory;

public class Tree : IObstacle
{
    public void interact()
    {
        Console.WriteLine("interact with tree");
    }
}
public class Rock : IObstacle
{
    public void interact()
    {
        Console.WriteLine("interact with Rock");

    }
}