using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        public int Bid;
        public string Name;
        public double Price;
        public string Author;

        
        public Book(int bid, string name, double price, string author)
        {
            Bid = bid;
            Name = name;
            Price = price;
            Author = author;
        }

        public void DisplayBookDetails()
        {
            Console.WriteLine("Book ID: " + Bid);
            Console.WriteLine("Book Name: " + Name);
            Console.WriteLine("Price: $" + Price);
            Console.WriteLine("Author: " + Author);
        }
    }

}

