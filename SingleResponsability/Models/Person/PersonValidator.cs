using System;
using SingleResponsability.Utils;

namespace SingleResponsability.Models.Person
{
    public class PersonValidator
    {
        public static (bool, string) IsValid(Person person)
        {
            if (String.IsNullOrWhiteSpace(person.Firstname))
                return (false, StandardMessages.Validation.INVALID_FIRST_NAME);

            if (String.IsNullOrWhiteSpace(person.Lastname))
                return (false, StandardMessages.Validation.INVALID_LAST_NAME);

            return (true, "");
        }
    }
}

