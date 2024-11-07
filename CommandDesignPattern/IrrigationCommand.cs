namespace CommandDesignPattern;

public class TurnOnIrrigationCommand : IInstruction
{
    private Irrigation _irrigation;
    public TurnOnIrrigationCommand(Irrigation irrigation)
    {
        _irrigation = irrigation;
    }
    public void Execute()
    {
        _irrigation.Open();
    }
}

public class TurnOffIrrigationCommand : IInstruction
{
    private Irrigation _irrigation;
    public TurnOffIrrigationCommand(Irrigation irrigation)
    {
        _irrigation = irrigation;
    }
    public void Execute()
    {
        _irrigation.Close();
    }
}
