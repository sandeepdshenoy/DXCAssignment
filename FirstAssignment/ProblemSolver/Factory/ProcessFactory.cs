using ActionProcessor;
using SequenceAnalysis;
using SumOfMultiples;

namespace ProblemSolver.Factory
{
    public static class ProcessFactory
    {
        public static IProcessor GetProcessor(int Input)
        {
            switch (Input)
            {
                case 2:
                    return new SequanceAnalysis();
                case 1:
                    return new SumOfMultiple();
            }
            return null;
        }
    }
}
