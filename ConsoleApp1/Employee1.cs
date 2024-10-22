using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee1
    {
        public int id;
        public string name;
        public string Department;
          
        public Employee1()
        {
            id = 1;
            name = "yashita";
            Department = "it";
        }
        public Employee1(int id,string name)
        {
            id = 2;
            name = "nita";
            Department = "mech";
        }
        public Employee1(int id, string name,string Department)
        {
            id = 3;
            name = "sita";
            Department = "chem";

        }
        public void  Display()
        {
            Console.WriteLine($"id:{id} ,Name: {name},Department: {Department}");

        }
        
    }
}
