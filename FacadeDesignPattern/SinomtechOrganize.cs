namespace Sinomtech;

public class SinomtechOrganize
{
    private readonly IDecorationServices _decorationServices;
    private readonly IDocumentationServices _documentationServices;
    private readonly ICateringServices _cateringServices;

    public SinomtechOrganize()
    {
        _cateringServices = new CateringServices("");
    }
}
