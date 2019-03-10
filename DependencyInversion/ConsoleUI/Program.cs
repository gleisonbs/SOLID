using System;
using DIPLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Gleison";
            owner.LastName = "B";
            owner.EmailAddress = "gleisonbs@gmail.com";
            owner.PhoneNumber = "555-1212";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadKey();
        }
    }
}
