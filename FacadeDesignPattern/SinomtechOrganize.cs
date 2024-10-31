namespace Sinomtech;

public class SinomtechOrganize
{
    private readonly IDecorationServices? _decorationServices;
    private readonly IDocumentationServices? _documentationServices;
    private ICateringServices? _cateringServices;

    public SinomtechOrganize()
    {

    }
    public bool SetCateringServices(ICateringServices cateringServices)
    {
        _cateringServices = cateringServices;
        return true;
    }
}
