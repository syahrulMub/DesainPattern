namespace Sinomtech;

public class CateringServices : ICateringServices
{
    private string _cateringName;
    public CateringServices(string cateringName)
    {
        _cateringName = cateringName;
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
    public void OpenMenu()
    {
        Console.WriteLine($"{_cateringName} is opening menu");
    }
}