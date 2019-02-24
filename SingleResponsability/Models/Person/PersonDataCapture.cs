using System;

namespace SingleResponsability.Models.Person
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person person = new Person();
            Console.Write("First name: ");
            person.Firstname = Console.ReadLine();

            Console.Write("Last name: ");
            person.Lastname = Console.ReadLine();

            return person;
        }
    }
}