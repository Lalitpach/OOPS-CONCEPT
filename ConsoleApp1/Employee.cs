using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        private int id;
        private string name;
        
        public int ID
        {
            set { id = value; }
            get { return id; }

        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public string print()
        {
            return $"employee is :{id}/{name}";
        }
    }
}
