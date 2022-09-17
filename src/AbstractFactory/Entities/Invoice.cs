namespace AbstractFactory.Entities
{
  public class Invoice
  {
    public Invoice(string type)
    {
      InvoiceType = type;
    }

    public string InvoiceType { get; private set; }

    public void PrintType()
    {
      Console.WriteLine($"Invoice Type: {InvoiceType}");
    }
  }
}
