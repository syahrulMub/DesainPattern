using CommandDesignPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Irrigation gardenIrrigation = new Irrigation("garden");
        Irrigation fishPond = new Irrigation("fish Pond");

        IInstruction onIrrigation = new TurnOnIrrigationCommand(gardenIrrigation);
        IInstruction offIrrigation = new TurnOffIrrigationCommand(gardenIrrigation);
        IrrigationControl remote = new();
        remote.SetInstruction(offIrrigation);

        IInstruction onFishPond = new TurnOnIrrigationCommand(fishPond);
        IInstruction offFishPond = new TurnOffIrrigationCommand(fishPond);

        remote.SetInstruction(onFishPond);
        remote.PressButton();
    }
}