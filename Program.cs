using System;
using VSConsoleApp1;

namespace VSConsoleApp1
{
    class Program
    {
        private static void Main(string[] args) 
        {
            String[] inputArray = {"aba", "aa", "ad", "vcd", "aba"};
            String[] outputArray = AllLongestStrings(inputArray);
            
            for (int i = 0; i < outputArray.Length; i++)
            {
                Console.WriteLine(outputArray[i]);
            }
        }

        private static String[] AllLongestStrings(String[] inputArray)
        {
            String[] outputArray = null;
            Int32 longestStringsCharLength = 0;
            Int32 longestStringsCount = 0;

            // get the longest string's character length
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > longestStringsCharLength)
                {
                    longestStringsCharLength = inputArray[i].Length;
                    longestStringsCount = 0;
                    longestStringsCount++;
                }
                else if (inputArray[i].Length == longestStringsCharLength)
                {
                    longestStringsCount++;
                }
            }

            // allocate size of the output array
            outputArray = new String[longestStringsCount];

            // add items to the output array
            for (int i = 0, j = 0; j < inputArray.Length; j++)
            {
                if (inputArray[j].Length == longestStringsCharLength)
                {
                    outputArray[i] = inputArray[j];
                    i++;
                }
            }

            return outputArray;
        }
    }
}