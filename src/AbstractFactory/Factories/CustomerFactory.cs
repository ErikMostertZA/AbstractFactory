using AbstractFactory.Entities;

namespace AbstractFactory.Factories
{
    public abstract class InvoiceFactory
    {
        public abstract Invoice CreateCustomerInvoice();
        public abstract Invoice CreateCorporateInvoice();
    }
}
