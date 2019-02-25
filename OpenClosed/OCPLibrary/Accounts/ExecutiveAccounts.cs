using System;

namespace OCPLibrary
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel()
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{person.FirstName.ToLower()}.{person.LastName.ToLower()}@acmecorp.com",
                IsExecutive = true,
                IsManager = true
            };

            return output;
        }
    }
}