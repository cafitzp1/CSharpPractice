using System;
using VSConsoleApp1;

namespace VSConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Int32[] arr = {2, 3, 4, 10, 40};
            Console.WriteLine(BinarySearch(arr, 0, arr.Length-1, 10));
        }

        private static int BinarySearch(Int32[] arr, Int32 l, Int32 r, Int32 x)
        {
            if(r >= l)
            {
                Int32 mid = l+(r-l)/2;

                if(arr[mid] == x)
                    return mid;

                if(arr[mid] < x)
                    return BinarySearch(arr, mid+1, r, x);

                return BinarySearch(arr, l, mid-1, x);
            }

            return -1;
        }
    }
}
