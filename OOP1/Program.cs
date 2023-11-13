// See https://aka.ms/new-console-template for more information
using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 10;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 50;

Product product2 = new Product() { Id = 2, CategoryId = 20, ProductName = "Kalem", UnitPrice = 600, UnitsInStock = 60};

ProductManager productManager = new ProductManager();
productManager.Add(product1);
productManager.Update(product1);
Console.WriteLine(product1.ProductName);

