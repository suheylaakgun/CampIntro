// See https://aka.ms/new-console-template for more information
using ClassMetotDemo;

Customer customer = new Customer();
customer.Id = 1;
customer.Name = "Süheyla";

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer);