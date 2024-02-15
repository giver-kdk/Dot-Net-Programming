using System;
using System.Linq;

namespace Indexer
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public double Salary { get; set; }
        public string Department { get; set; }  

        public Employee()
        {
            Id = 0;
            Name = "No Name";
            Salary = 0;
            Department = "No Department";
        }
        public Employee(int i, string n, double s, string d)
        {
            Id = i;
            Name = n;
            Salary = s;
            Department = d;
        }
        // This indexer returns the 'ith' string element of string array
        // Return type of the indexer becomes the 'value' type while assigning
        public object this[int i]
        {
            get
            {
                if (i == 0) return this.Id;
                else if (i == 1) return this.Name;
                else if (i == 2) return this.Salary;
                else if (i == 3) return this.Department;
                else return "Invalid Index";
            }
            set
            {
                if (i == 0) this.Id = (int) value;
                else if (i == 1) this.Name = (string) value;
                else if (i == 2) this.Salary = (double) value;
                else if (i == 3) this.Department = (string) value;
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee(123, "Ram", 90000, "IT");

            emp[0] = 456;
            emp[1] = "Hari";
            emp[2] = 100000;
            emp[3] = "Physics";

            Console.WriteLine(emp[0]);
            Console.WriteLine(emp[1]);
            Console.WriteLine(emp[2]);
            Console.WriteLine(emp[3]);
        }
    }
}