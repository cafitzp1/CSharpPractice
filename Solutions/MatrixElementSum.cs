using System;

namespace VSConsoleApp1.Solutions
{

/*
    // use as main method

    class Program
    {
        private static void Main(string[] args) 
        {
            int[][] jaggedArray = new int [][]
            {
                new int[] { 0, 1, 1, 2 },
                new int[] { 0, 5, 0, 0 }, 
                new int[] { 2, 0, 3, 3 } 
            };   

            int test = MatrixElementsSum.Run(jaggedArray);

            Console.WriteLine($"Test val: {test}");
        } 
    }
*/

    internal struct MatrixElementsSum
    {
        public static int Run(int[][] matrix)
        {
            Int32 runningSum = 0;

            // iterate each matrix column
            for(int i = 0; i<matrix[0].Length; i++)
            {
                // iterate each row
                for (int j = 0; j<matrix.Length; j++)
                {
                    // grab the element of array j, item i (aka column j, row i)
                    Int32 currentElement = matrix[j][i];

                    if(currentElement <= 0)
                    {
                        // exit loop for this column if a val is 0 or less
                        break;
                    }
                    else
                    {
                        // add val to running sum
                        runningSum += currentElement;
                    }
                }
            }

            return runningSum;
        }
    }
}