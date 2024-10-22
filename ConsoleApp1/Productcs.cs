using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Productcs
    {
        public int Code;
        public string Name;
        public double Price;

        
        public Productcs(int code, string name, double price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

       
        public double GetDiscountedPrice()
        {
            if (Price > 1000)
            {
                return Price * 0.90; 
            }
            return Price; 
        }

       
        public void DisplayProductDetails()
        {
            double discountedPrice = GetDiscountedPrice();
            Console.WriteLine("Product Code: " + Code);
            Console.WriteLine("Product Name: " + Name);
            Console.WriteLine("Original Price: $" + Price);
            Console.WriteLine("Discounted Price: $" + discountedPrice);
        }
    }

}

