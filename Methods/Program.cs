using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Description = "Amasya Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Description = "Diyarbakır Watermelon";

            Product[] products = new Product[] { product1, product2 };

            //The first "Product" is required because of the type-safe development language
            //The second "product" is an alias
            //The third "products" is the array of "products"
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("----------------------------");

            }

            Console.WriteLine("------------Methods-------------");

            //Instance
            //Encapsulation
            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);


            cartManager.Add2("Pear", "Green Pear", 12, 10);
            cartManager.Add2("Apple", "Green Apple", 20, 15);
            cartManager.Add2("Watermelon", "Diyarbakır Watermelon", 50, 1);

        }
    }
}

//Principle: Do not repeat yourself!
//Clean Code