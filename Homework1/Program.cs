using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Powerbank";
            product1.ProductDescription = "Elektronik cihazlarınızı şarj etmek için kullanabileceğiniz bir güç kaynağı";
            product1.ProductPrice = 70;

            Product product2 = new Product();
            product2.ProductName = "Roman";
            product2.ProductDescription = "Heyecan dolu bir polisiye";
            product2.ProductPrice = 38;

            Product product3 = new Product();
            product3.ProductName = "Playstation 5";
            product3.ProductDescription = "Video oyunlarla eğlenin!";
            product3.ProductPrice = 10000;

            Console.WriteLine("--------------------------------------------------");

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + ", " + product.ProductDescription + ", " + product.ProductPrice);
            }
            
            Console.WriteLine("--------------------------------------------------");

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + ", " + products[i].ProductDescription + ", " + products[i].ProductPrice);
            }

            Console.WriteLine("--------------------------------------------------");

            int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine(products[a].ProductName + ", " + products[a].ProductDescription + ", " + products[a].ProductPrice);
                a++;
            }
        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
    }
}
