using CommandDesignPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Irrigation gardenIrrigation = new Irrigation();

        IInstruction onIrrigation = new TurnOnIrrigationCommand(gardenIrrigation);
        IInstruction offIrrigation = new TurnOffIrrigationCommand(gardenIrrigation);
        IrrigationControl remote = new();


    }
}