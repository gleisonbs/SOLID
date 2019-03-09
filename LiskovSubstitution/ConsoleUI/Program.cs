using System;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager ceo = new CEO();
            ceo.FirstName = "Emma";
            ceo.LastName = "Stone";
            ceo.CalculatePerHourRate(1);

            IManaged emp = new Manager();
            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(ceo);
            emp.CalculatePerHourRate(6);

            Console.WriteLine($"{ceo.FirstName}'s salary is ${ceo.Salary}/hour");
            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour");
            Console.ReadKey();
        }
    }
}
