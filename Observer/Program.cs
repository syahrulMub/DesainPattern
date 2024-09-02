using System.Collections.Generic;
namespace StockAndTrader;
//definition class for changes information

public class StockChangeEventArgs : EventArgs
{
    public string CompanyName { get; set; }
    public decimal PriceChange { get; set; }
}


//definition class for stock
public class Stock
{
    public event EventHandler<StockChangeEventArgs> PriceChanged;
    public string CompanyName { get; }
    private decimal _price;
    public Stock(string CompanyName, decimal PriceChange)
    {
        this.CompanyName = CompanyName;
        _price = PriceChange;
    }

    //method for update price
    public void UpdatePrice(decimal newPrice)
    {
        _price = newPrice;
        onPriceChanged(new StockChangeEventArgs
        {
            CompanyName = CompanyName,
            PriceChange = newPrice,
        });
    }
    //method for notifying subscribers
    protected virtual void onPriceChanged(StockChangeEventArgs args)
    {
        PriceChanged?.Invoke(this, args);
    }
}

//definition class for stock trader

public class Investor
{
    private string _name;
    public Investor(string name)
    {
        _name = name;
    }
    public void OnStockChanged(object sender, StockChangeEventArgs e)
    {
        Console.WriteLine($"{_name} has received a price change for {e.CompanyName}. New price: {e.PriceChange}");
    }
}

public class Program
{
    public static void Main()
    {
        Stock googleStock = new Stock("Google", 100);
        Stock amazonStock = new Stock("Amazon", 200);

        Investor kroz = new Investor("Kroz");
        Investor Fah = new Investor("Fah");

        googleStock.PriceChanged += kroz.OnStockChanged;
        googleStock.PriceChanged += Fah.OnStockChanged;
        amazonStock.PriceChanged += kroz.OnStockChanged;

        googleStock.UpdatePrice(200);
        amazonStock.UpdatePrice(300);
    }
}