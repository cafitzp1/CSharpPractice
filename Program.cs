using System;
using VSConsoleApp1;

namespace VSConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] testInput = {2, 3, 10, 3, 40};
            Console.WriteLine(AlmostIncreasingSequence(testInput));
        }

        private static bool AlmostIncreasingSequence(int[] sequence)
        {
            bool foundOne = false;

            for (int i = -1, j = 0, k = 1; k < sequence.Length; k++)
            {
                bool deleteCurrent = false;

                if (sequence[j] >= sequence[k])
                {
                    if (foundOne)
                    {
                        return false;
                    }
                    foundOne = true;

                    if (k > 1 && sequence[i] >= sequence[k])
                    {
                        deleteCurrent = true;
                    }
                }

                if (!foundOne)
                {
                    i = j;
                }

                if (!deleteCurrent)
                {
                    j = k;
                }
            }

            return true;
        }
    }
}