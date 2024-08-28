
public class GopayPayment
{
    public void PaymentMethod(decimal payment)
    {
        Console.WriteLine($"success payment with Gopay : {payment}");
    }
}

public class OvoPayment
{
    public void Pay(int count)
    {
        Console.WriteLine($"success payment with Ovo : {count}");
    }
}

public interface IPayment
{
    void Payment(decimal amout);
}

public class GopayPaymentAdapter : IPayment
{
    private readonly GopayPayment _gopay;

    public GopayPaymentAdapter(GopayPayment gopay)
    {
        _gopay = gopay;
    }
    public void Payment(decimal amount)
    {
        _gopay.PaymentMethod(amount);
    }
}

public class OvoPaymentAdapter : IPayment
{
    private readonly OvoPayment _ovo;

    public OvoPaymentAdapter(OvoPayment ovo)
    {
        _ovo = ovo;
    }

    public void Payment(decimal amount)
    {
        _ovo.Pay((int)amount);
    }
}


public class MyApplicationPayment
{
    private readonly IPayment _payment;

    public MyApplicationPayment(IPayment payment)
    {
        _payment = payment;
    }

    public void ProcessPayment(decimal amount)
    {
        _payment.Payment(amount);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        GopayPayment gopayAPI = new GopayPayment();
        OvoPayment ovoAPI = new OvoPayment();

        GopayPaymentAdapter gopay = new GopayPaymentAdapter(gopayAPI);
        OvoPaymentAdapter ovo = new OvoPaymentAdapter(ovoAPI);

        var processPertama = new MyApplicationPayment(gopay);
        processPertama.ProcessPayment(300);
        var processKedua = new MyApplicationPayment(ovo);
        processKedua.ProcessPayment(200);
    }
}
