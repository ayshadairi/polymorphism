using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable quittableEmployee = new Employee { Id = 1, FirstName = "Sam", LastName = "Harison" };
            quittableEmployee.Quit();

            Console.ReadLine();
        }
    }
}
