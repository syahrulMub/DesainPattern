namespace Sinomtech;

public interface IDocumentationServices
{
    bool SetDocumentationServices(string documentation);
    string GetDocumentationServices();
    void TakeVideo();
    void TakePicture();
}