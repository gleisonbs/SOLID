using System;

namespace SingleResponsability.Utils
{
    public class StandardMessages
    {
        public static class Validation 
        {
            public static string INVALID_FIRST_NAME { get; } = "Invalid first name";
            public static string INVALID_LAST_NAME { get; } = "Invalid last name";
        }

        public static string WELCOME { get; } = "Welcome to my application!";
        public static string PRESS_KEY_TO_EXIT { get; } = "Press any key to exit"
        public static void WelcomeMessage()
        {
            Console.WriteLine(WELCOME);
        }

        public static void EndApplication(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}