using Sinomtech;

namespace FacadeDesignPattern;

public class DocumentationServices : IDocumentationServices
{
    private string? _name;

    public DocumentationServices()
    {
    }
    public bool SetDocumentationServices(string documentation)
    {
        _name = documentation;
        return true;
    }
    public string GetDocumentationServices()
    {
        return _name ?? "documentation not yet set";
    }
    public void TakePicture()
    {
        Console.WriteLine($"{_name} taking a picture");
    }
    public void TakeVideo()
    {
        Console.WriteLine($"{_name} taking a video");
    }
}
