using ActionProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfMultiples
{
    public class SumOfMultiple : IProcessor
    {
        public bool PerformAction(string Input)
        {
            int sum = 0;

            for (int i = 1; i < Convert.ToInt32(Input); i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("The sum of all natural numbers that are a multiple of 3 or 5 below {0} is {1}.", Input, sum);
            return true;
        }
    }
}
