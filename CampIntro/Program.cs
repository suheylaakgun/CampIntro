// See https://aka.ms/new-console-template for more information
using Methods;
using System.ComponentModel;

Product product1 = new Product();
product1.Id = 1;
product1.Name = "Elma";
product1.Price = 15;
product1.Description = "Amasya Elması";

Product product2 = new Product();
product2.Id = 2;
product2.Name = "Karpuz";
product2.Price = 10;
product2.Description = "Diyarbakır karpuzu";

Product[] products = new Product[] { product1, product2 };

foreach (Product product in products)
{
    Console.WriteLine(product.Id);
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Description);
    Console.WriteLine("--------------------------------------------");
}

Console.WriteLine("------------------Metotlar--------------------------");

//Encapsulation;
//Proje geliştirildikçe ayrı ayrı parametrelerin olduğu yerler prog. birçok yerinde değşiklik gerektirir.
//class örneğini parametre olarak geçmek ise yalnızca ilgili sınıfa ekleme yapılması ile işlem tamamlanır.
BasketManager basketManager = new BasketManager();
basketManager.Add(product1);
basketManager.Add(product2);

//overload metot 
basketManager.Add("Armut", "Yeşil Armut", 10, 5);
basketManager.Add("Elma", "Amasya Elması", 20, 10);
basketManager.Add("Karpuz", "Diyarbakır Karpuzu", 30, 15);

//ref keywordü ile içeriğinin değişmemesini istediğimiz değişkenleri kullanabiliriz.
//out keywordü ile ref benzer işler yapar outta başlangıç değeri ihtiyacı yoktur, kullanıldığı an itibariyle 1 kere set edilmesi yeterlidir. Refte başlangıç değeri ihtiyacı vardır.
int kdv = 20;
int number = 5;
var result = Add2(kdv, number);
Console.WriteLine(kdv);
Console.WriteLine(result);
var result2 = Add(ref kdv, number);
Console.WriteLine(kdv);
Console.WriteLine(result);



static int Add(ref int kdv, int number)
{
    kdv = 999;
    return kdv + number;
}

static int Add2(int kdv, int number)
{
    kdv = 999;
    return kdv + number;
}

