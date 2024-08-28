namespace GameFactory;

public class Jungle : IMap
{
    private readonly IEnumerable<IEnemy> _enemies;
    private readonly IEnumerable<IObstacle> _obstacles;

    public jungle()
    {
        _enemies = new List<IEnemy>();
        _obstacles = new List<IObstacle>();
    }
    public IEnemy CreateEnemy()
    {
        return new Ogre();
    }

    public IObstacle CreateObstacle()
    {
        return new Rock();
    }
}

//if we depending one map with an enemy and Obstacle
public class Mountain
{
    public Ogre CreateEnemy()
    {
        return new Ogre();
    }
    public Rock CreateObstacle()
    {
        return new Rock();
    }
}