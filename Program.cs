using System;
using System.Reflection;
using VSConsoleApp1;

namespace VSConsoleApp1
{
    class Program
    {
        private static void Main(string[] args) 
        {
            Console.WriteLine(fibonacci(3));
        } 

        private static Int32 fibonacci(Int32 number)
        {
            if (number < 2) 
                return number;
                
            return fibonacci(number - 1) + fibonacci(number - 2);
        }
    }
}
