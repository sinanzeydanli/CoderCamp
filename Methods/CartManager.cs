using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        public void Add(Product product) //Naming convention
        {
            Console.WriteLine("Congrats, added to the cart : " + product.Name);
        }

        public void Add2(string productName, string productDescription, double productPrice, int stockAmount)
        {
            Console.WriteLine("Congrats, added to the cart : " + productName);
        }
    }
}
