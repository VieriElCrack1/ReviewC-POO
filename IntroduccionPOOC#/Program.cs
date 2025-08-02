
Sale sale = new Sale(100);

var message = sale.getSale();

Console.WriteLine(message);

class Sale
{
    public decimal total { get; set; }
    private decimal some;

    public Sale(decimal total)
    {
        this.total = total;
        this.some = 8;
    }

    public string getSale()
    {
        return $"Total sale: {total}";
    }
}