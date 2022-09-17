using AbstractFactory.Entities;

namespace AbstractFactory.Factories
{
  public class SwitzerlandFactory : InvoiceFactory
  {
    public override Invoice CreateCorporateInvoice()
    {
      return new Invoice("Swiss Corporate");
    }

    public override Invoice CreateCustomerInvoice()
    {
      return new Invoice("Swiss Customer");
    }
  }
}
