using System;

namespace polymorphism
{
    //Have the Employee class from the previous drill inheret that interface and implement the Quit() method in any way i choose.
    public class Employee : IQuittable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit the company.");
        }
    }
}
