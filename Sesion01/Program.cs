using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion01
{
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>();
            var combo = new List<Product>();
            var product1 = new ProductFixPrice(100, "Leche", 2300M, .19f);
            var product2 = new ProductFixPrice(200, "Pan", 1500M, .19f);
            var product3 = new ProductVariablePrice(300, "Mango", "Kilo", 5200M, 1.534f, .1f);
            var product4 = new ProductVariablePrice(400, "Cable", "Metros", 5200M, 50.5f, .19f);

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            combo.Add(product1);
            combo.Add(product2);
            combo.Add(product3);
            combo.Add(product4);

            var product5 = new CompositedProduct(500, "Ancheta Especial" , combo);

            decimal value = 0;
            decimal tax = 0;



            foreach (var product in products)
            {
                Console.WriteLine(product);
                value += product.GetPrice();
                tax += product.GetTax();

            }

            Console.WriteLine($"=====================================");
            Console.WriteLine($"TOTAL TO PAY................: {value,12:C2}");
            Console.WriteLine($"TOTAL TO TAX................: {tax,12:C2}");

            Console.WriteLine("Press ENTER to finish...");
            Console.ReadKey();
        }
    }
}
