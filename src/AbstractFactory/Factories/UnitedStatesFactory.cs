using AbstractFactory.Entities;

namespace AbstractFactory.Factories
{
  public class UnitedStatesFactory : InvoiceFactory
  {
    public override Invoice CreateCorporateInvoice()
    {
      return new Invoice("USA Corporate");
    }

    public override Invoice CreateCustomerInvoice()
    {
      return new Invoice("USA Customer");
    }
  }
}
