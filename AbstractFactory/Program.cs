using GameFactory;

class Program
{
    static void Main(string[] args)
    {
        IMap jungle = new Jungle();
        GameEngine gr = new GameEngine(jungle);
        gr.Play();
    }
}