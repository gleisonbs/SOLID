using System;
using SingleResponsability.Utils;
using SingleResponsability.Models.Person;

namespace SingleResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();
            
            Person user = PersonDataCapture.Capture();
            var (isValid, msg) = PersonValidator.IsValid(user);
            if (isValid == false)
            {
                StandardMessages.EndApplication(msg);
                return;
            }

            AccountGenerator.Generate(user);
            StandardMessages.EndApplication(StandardMessages.PRESS_KEY_TO_EXIT);
        }
    }
}
