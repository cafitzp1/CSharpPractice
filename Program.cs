using System;
using System.Reflection;
using VSConsoleApp1;

namespace VSConsoleApp1
{
    class Program
    {
        private static void Main(string[] args) 
        {
            dynamic target = "Connor";
            dynamic arg = "nn";
            Boolean result = target.Contains(arg);

     	    Console.WriteLine("Hello, this is a test.");    
        } 
    }
}
