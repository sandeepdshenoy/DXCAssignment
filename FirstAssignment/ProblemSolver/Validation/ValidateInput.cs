using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolver.Validation
{
    public static class ValidateInput
    {
        public static bool ValidateUserInput(string input, out int Input)
        {           
            if (!int.TryParse(input, out Input))
            {
                Console.WriteLine($"Input {input} is not in the right format, please choose 1 or 2.");
                Console.ReadLine();
                return false;
            }
            if (Input != 1 && Input != 2)
            {
                Console.WriteLine($"Input {input} is not in the options, choose 1 or 2.");
                Console.ReadLine();
                return false;
            }

            return true;
        }
    }
}
