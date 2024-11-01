namespace Sinomtech;

public class DecorationServices : IDecorationServices
{
    private string? _decorationName;

    public DecorationServices()
    {
    }
    public bool SetDecorationServices(string decorationName)
    {
        if (decorationName == null)
        {
            Console.WriteLine("Invalid decoration name.");
            return false;
        }
        else
        {
            _decorationName = decorationName;
            return true;
        }
    }
    public string GetDecorationServices()
    {
        return _decorationName ?? "Unknown decoration";
    }
    public void SetDecoration()
    {
        Console.WriteLine($"{_decorationName} decoration is set.");
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