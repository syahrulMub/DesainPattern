using Sinomtech;

namespace FacadeDesignPattern;

public class DocumentationServices : IDocumentationServices
{
    private string _name;

    public DocumentationServices(string name)
    {
        _name = name;
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
