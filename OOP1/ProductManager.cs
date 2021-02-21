using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //ENCAPSULATION
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " added.");//simulasyon

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " updated.");//simulasyon

        }

    }
}
