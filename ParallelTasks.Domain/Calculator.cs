using System;
using System.Threading.Tasks;

namespace ParallelTasks.Domain
{
    public static class Calculator
    {
        public static async Task<double> CalculateInterest()
        {
            double finalValue = 100;
            
            for (int index = 1; index <= 100000; index++)
            {
                Console.WriteLine("Calculate Interest " + index);
                finalValue = Math.Truncate(finalValue * Math.Pow(1 + 0.1, index) * 100) / 100;
            }
            
            return finalValue;
        }
    }
}