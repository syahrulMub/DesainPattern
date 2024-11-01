namespace Sinomtech;

public interface IDecorationServices
{
    bool SetDecorationServices(string decorationServices);
    string GetDecorationServices();
    void ChooseColor(string color);
    void ChoosePattern(string pattern);
    void SetDecoration();
}