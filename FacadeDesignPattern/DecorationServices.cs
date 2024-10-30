namespace Sinomtech;

public class DecorationServices : IDecorationServices
{
    private string _decorationName;

    public DecorationServices(string decorationName)
    {
        _decorationName = decorationName;
    }

    public void ChooseColor(string color)
    {
        Console.WriteLine($"Choose {_decorationName} color as {color}");
    }

    public void ChoosePattern(string pattern)
    {
        Console.WriteLine($"Choose {_decorationName} pattern as {pattern}");
    }
}