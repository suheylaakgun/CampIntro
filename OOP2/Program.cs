// See https://aka.ms/new-console-template for more information

using OOP2;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNo = "123456";
customer1.FirstName = "Engin";
customer1.LastName = "Demiroğ";
customer1.TcNo = "1234567890";

CorporateCustomer customer2 = new CorporateCustomer();
customer2.Id = 2;
customer2.CustomerNo = "54321";
customer2.CompanyName = "Kodlama.io";
customer2.TaxNo = "1234567890";

//Gerçek Müşteri - Tüzel Müşteri
//SOLID

Customer customer3 = new IndividualCustomer();
Customer customer4 = new CorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);