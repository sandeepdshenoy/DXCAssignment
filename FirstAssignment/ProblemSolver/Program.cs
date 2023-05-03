using ActionProcessor;
using System;
using System.Text;

namespace ProblemSolver
{
    public class Program
    {        
        public static void Main(string[] args)
        {
            StringBuilder stringbuilder = CreateMenu();

            Console.WriteLine(stringbuilder.ToString());
            string userInput = Console.ReadLine();
            int ParsedInput;
            if (Validation.ValidateInput.ValidateUserInput(userInput, out ParsedInput))
            {
                IProcessor userOption = Factory.ProcessFactory.GetProcessor(ParsedInput);
                switch (ParsedInput)
                {
                    case 1:
                        Console.WriteLine($"Enter the Inut digit to calculate Sum Of Multiple.");
                        break;
                    case 2:
                        Console.WriteLine($"Enter the Inut sentance to calculate Sequence");
                        break;
                }
                string secondInput = Console.ReadLine();
                userOption.PerformAction(secondInput);
                Console.ReadLine();
            }

        }

        private static StringBuilder CreateMenu()
        {
            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.AppendLine($"Choose What Problem you want to solve: ");
            stringbuilder.AppendLine($"1.SumOfMultiple(Find the sum of all natural numbers that are a multiple of 3 or 5 below a limit provided as input).");
            stringbuilder.AppendLine($"2.SequenceAnalysis (Uppercase characters in the given input sorted in alphabetical order).");
            return stringbuilder;
        }
    }
}
