using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("-- Testing Fibonacci Brute --");
            Console.WriteLine("Small Fib:");
            Console.WriteLine(FibonacciBrute.FibBrute(6));
            Console.WriteLine("Large Fib:");
            Console.WriteLine("Commented out to save computing time");
            //Console.WriteLine(FibonacciBrute.FibBrute(50));
            Console.WriteLine("------------------------------");
            Console.WriteLine("-- Testing Fibonacci Memoized --");
            Console.WriteLine("Small Fib:");
            Console.WriteLine(FibonacciMemo.FibMemo(6));
            Console.WriteLine("Large Fib:");
            Console.WriteLine(FibonacciMemo.FibMemo(50));
            Console.WriteLine("------------------------------");
            Console.ReadLine();
        }
    }
    
}