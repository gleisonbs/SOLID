using System;

namespace DemoLibrary
{
    public abstract class BaseEmployee : IBaseEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50m;
            Salary = baseAmount * rank;
        }
    }
}
