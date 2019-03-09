using System;

namespace DemoLibrary
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150m;
            Salary = baseAmount * rank;
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Reviewing a performance report");
        }

        public void FireSomeone()
        {
            Console.WriteLine("Firing...");
        }
    }
}
