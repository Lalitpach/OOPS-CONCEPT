
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Roll No:");
            //int rollNo = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Name:");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter Marks for Subject 1:");
            //int marks1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Marks for Subject 2:");
            //int marks2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Marks for Subject 3:");
            //int marks3 = int.Parse(Console.ReadLine());

            //// Create a Student object using the constructor
            //studentcs student = new studentcs(rollNo, name, marks1, marks2, marks3);

            //// Display the student's details
            //student.DisplayStudentDetails();


            //Console.WriteLine("Enter Book ID:");
            //int bid = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Book Name:");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter Book Price:");
            //double price = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Author Name:");
            //string author = Console.ReadLine();


            //Book myBook = new Book(bid, name, price, author);

            //myBook.DisplayBookDetails();

            //            Console.WriteLine("Enter Product Code:");
            //            int code = int.Parse(Console.ReadLine());

            //            Console.WriteLine("Enter Product Name:");
            //            string name = Console.ReadLine();

            //            Console.WriteLine("Enter Product Price:");
            //            double price = double.Parse(Console.ReadLine());

            //            Productcs myProduct = new Productcs(code, name, price);


            //            myProduct.DisplayProductDetails();
            //Employee e1 = new Employee();
            //e1.ID = 101;
            //e1.Name = "nita";
            //Console.WriteLine($"employe is {e1.ID} / {e1.Name}");

            //Date d1 = new Date();
            //d1.Day = 15;
            //d1.Month = "oct";
            //d1.Year = 2024;
            //Console.WriteLine($"Date is {d1.Day}/ {d1.Month} / {d1.Year}");
            Calculator c1 = new Calculator();
            Console.WriteLine(c1.Add(12, 15));
            Console.WriteLine(c1.multipication(32, 15));
            Console.WriteLine(c1.sub(25, 15));



        }
   }
}

