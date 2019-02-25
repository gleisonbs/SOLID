using System;
using System.Collections.Generic;
using OCPLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new ApplicantModel { FirstName = "Tim", LastName = "Corey" },
                new ExecutiveModel { FirstName = "Sue", LastName = "Storm" },
                new ApplicantModel { FirstName = "Nancy", LastName = "Roman" },
                new ManagerModel { FirstName = "John", LastName = "Haack" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
                employees.Add(person.AccountProcessor.Create(person));
            
            foreach (var emp in employees)
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} {emp.IsManager} {emp.IsExecutive}");

            Console.ReadKey();
        }
    }
}
