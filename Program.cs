using System;
using VSConsoleApp1;

namespace VSConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Int32[] arr = {2, 3, 4, 10, 40};

            // write the index of element '10' to the console
            Console.WriteLine(BinarySearch(arr, 0, arr.Length-1, 10));
        }

        private static int BinarySearch(Int32[] arr, Int32 l, Int32 r, Int32 x)
        {
            if(r >= l)
            {
                // get the mid array index
                Int32 mid = l+(r-l)/2;

                // return this index if array index at mid already matches
                if(arr[mid] == x)
                    return mid;

                // recursively call binarysearch halving the lowerlimit (l) if x is greater than the midpoint
                if(arr[mid] < x)
                    return BinarySearch(arr, mid+1, r, x);

                // recursively call binarysearch halving the upper limit (r) if x is less than the midpoint
                return BinarySearch(arr, l, mid-1, x);
            }

            // element was not in the array if we reach this point
            return -1;
        }
    }
}