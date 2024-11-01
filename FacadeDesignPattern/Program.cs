using Sinomtech;

public class Program
{
    static void Main(string[] args)
    {
        IDecorationServices ds = new DecorationServices();
        ICateringServices cs = new CateringServices();
        ds.SetDecorationServices("syahrul dekor");
        cs.SetCateringServices("syahrul catering");

        SinomtechOrganize sinomtech = new SinomtechOrganize();
        sinomtech.SetCateringServices(cs);
        sinomtech.SetDecorationServices(ds);
        sinomtech.SetPreparationPlace();
    }
}