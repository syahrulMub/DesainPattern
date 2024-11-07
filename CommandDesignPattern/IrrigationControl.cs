namespace CommandDesignPattern;

public class IrrigationControl
{
    private IInstruction? _instruction;
    public void SetInstruction(IInstruction instruction)
    {
        _instruction = instruction;
    }
    public void PressButton()
    {
        _instruction?.Execute();
    }
}
