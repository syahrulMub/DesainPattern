namespace Sinomtech;

public class CateringServices : ICateringServices
{
    private string? _cateringName;
    public CateringServices()
    {
    }

    public bool SetCateringServices(string service)
    {
        if (service == null)
        {
            Console.WriteLine("Invalid catering name.");
            return false;
        }
        else
        {
            _cateringName = service;
            return true;
        }
    }
    public string GetCateringServices()
    {
        return _cateringName ?? "Unknown catering";
    }
    public void SetMenuPlanning(string menuPlanning)
    {
        Console.WriteLine($"{_cateringName} is planning menu: {menuPlanning}");
    }
    public void CountGuestMenu(int guest)
    {
        Console.WriteLine($"{_cateringName} is counting menu for {guest} guests");
    }
    public void CalculateTotalPrice(decimal pricePerItem)
    {
        Console.WriteLine($"{_cateringName} is calculating total price for menu");
    }
    public void SetCateringStand()
    {
        Console.WriteLine($"{_cateringName} is setting up catering stand");
    }
    public void OpenMenu()
    {
        Console.WriteLine($"{_cateringName} is opening menu");
    }
}