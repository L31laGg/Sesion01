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
            var product1 = new ProductFixPrice(100, "Leche", 2300M, .19f);
            var product2 = new ProductFixPrice(200, "Pan", 1500M, .19f);

            products.Add(product1);
            products.Add(product2);

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("Press ENTER to finish...");
            Console.ReadKey();
        }
    }
}
