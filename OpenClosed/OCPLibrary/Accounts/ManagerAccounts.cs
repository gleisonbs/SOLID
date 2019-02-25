using System;

namespace OCPLibrary
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel()
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{person.FirstName.ToLower()}.{person.LastName.ToLower()}@acmecorp.com",
                IsManager = true
            };

            return output;
        }
    }
}
