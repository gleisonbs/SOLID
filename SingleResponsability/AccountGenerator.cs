using System;

namespace SingleResponsability
{
    public class AccountGenerator
    {
        public static void Generate(Person user)
        {
            Console.WriteLine($"Your username is {user.Firstname.Substring(0,1).ToLower()}.{user.Lastname.ToLower()}");
        }
    }
}