using System.ComponentModel;

namespace CommandDesignPattern;

public class Irrigation
{
    private string _position;
    public Irrigation(string position)
    {
        _position = position;
    }
    public void Open()
    {
        Console.WriteLine($"{_position} Irrigation system is opened.");
    }
    public void Close()
    {
        Console.WriteLine($"{_position} Irrigation system is closed.");
    }
    public void SetIrrigationVolume(float volume)
    {
        Console.WriteLine($"{_position} Irrigation system is set to volume {volume}");
    }
}
