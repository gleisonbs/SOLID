using System;

namespace OCPLibrary
{
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel()
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{person.FirstName.ToLower()}.{person.LastName.ToLower()}@acme.com",
            };

            return output;
        }
    }
}
