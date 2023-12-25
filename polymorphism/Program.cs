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
            //used polymorphism to create an object of type IQuittable and call the Quit() method on it.
            IQuittable quittableEmployee = new Employee { Id = 1, FirstName = "Sam", LastName = "Harison" };
            quittableEmployee.Quit();

            Console.ReadLine();
        }
    }
}
