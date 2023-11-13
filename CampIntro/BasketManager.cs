using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class BasketManager
    {
        //Naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler ! Ürün Sepete Eklendi "+ product.Name);
        }
        public void Add(string productName, string productDescription, double productPrice, int stockQuantity)
        {
            Console.WriteLine("Tebrikler ! Ürün Sepete Eklendi " + productName);
        }
    }
}
