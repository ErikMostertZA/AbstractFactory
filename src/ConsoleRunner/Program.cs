
using AbstractFactory.Factories;

var american = new UnitedStatesFactory();
var swiss = new SwitzerlandFactory();

var usaCorporateInvoice = american.CreateCorporateInvoice();
var usaCustomerInvoice = american.CreateCustomerInvoice();

usaCorporateInvoice.PrintType();
usaCustomerInvoice.PrintType();

var swissCorporateInvoice = swiss.CreateCorporateInvoice();
var swissCustomerInvoice = swiss.CreateCustomerInvoice();

swissCorporateInvoice.PrintType();
swissCustomerInvoice.PrintType();
