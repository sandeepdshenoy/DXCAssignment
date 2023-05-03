using System;

namespace SecondAssesment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Pass X & Y to find Is X Divisible By Y");
            string input = Console.ReadLine();

            string[] values = input.Split(' ');

            int result = IsXDivisibleByY(Convert.ToInt32(values[0]), Convert.ToInt32(values[1]));

            Console.WriteLine(result == 1 ? "X can be divided by Y without a remainder": "X can't be divided by Y without a remainder");
            Console.ReadLine();
        }

        public static int IsXDivisibleByY(int X, int Y)
        {
            var mo = (int)((float)X % (float)Y);
            var ac = 0;
            for (var i = 0; i < 32; i++)
            {
                ac = ac | (mo & 1);
                mo = mo >> 1;
            }

            return ac ^ 1;
        }
    }
}
