namespace Sinomtech;

public class SinomtechOrganize
{
    private IDecorationServices? _decorationServices;
    private IDocumentationServices? _documentationServices;
    private ICateringServices? _cateringServices;

    public SinomtechOrganize()
    {

    }
    public bool SetCateringServices(ICateringServices cateringServices)
    {
        _cateringServices = cateringServices;
        return true;
    }
    public bool SetDecorationServices(IDecorationServices decorationServices)
    {
        _decorationServices = decorationServices;
        return true;
    }
    public bool SetDocumentationServices(IDocumentationServices documentationServices)
    {
        _documentationServices = documentationServices;
        return true;
    }
    public bool SetPreparationPlace()
    {
        _cateringServices?.SetCateringStand();
        _decorationServices?.SetDecoration();
        return true;
    }
}