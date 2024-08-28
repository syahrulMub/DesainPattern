namespace GameFactory;

public class Ogre : IEnemy
{
    public void Attact()
    {
        Console.WriteLine("Attact from Ogre");
    }
}
public class Goblin : IEnemy
{
    public void Attact()
    {
        Console.WriteLine("Attact from Goblin");
    }
}

public class Eagle : IEnemy
{
    public void Attact()
    {
        Console.WriteLine("Attact from Eagle");
    }
}