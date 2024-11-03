using FacadeDesignPattern;
using Sinomtech;

public class Program
{
    static void Main(string[] args)
    {
        IDecorationServices ds = new DecorationServices();
        ICateringServices cs = new CateringServices();
        IDocumentationServices dcs = new DocumentationServices();
        ds.SetDecorationServices("syahrul dekor");
        cs.SetCateringServices("syahrul catering");
        dcs.SetDocumentationServices("hikam documentation");


        SinomtechOrganize sinomtech = new SinomtechOrganize();
        sinomtech.SetCateringServices(cs);
        sinomtech.SetDecorationServices(ds);
        sinomtech.SetDocumentationServices(dcs);
        sinomtech.SetPreparationPlace();
    }
}