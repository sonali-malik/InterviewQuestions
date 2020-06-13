using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Fibonacci
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Finder!");
            Console.WriteLine($"0 ={Fib(0)}"); // 0
            Console.WriteLine($"1 ={Fib(1)}"); // 1
            Console.WriteLine($"2 ={Fib(2)}"); // 1
            Console.WriteLine($"3 ={Fib(3)}"); // 2
            Console.WriteLine($"4 ={Fib(4)}"); // 3
            Console.WriteLine($"5 ={Fib(5)}"); // 5
            Console.WriteLine($"6 ={Fib(6)}"); // 8
            Console.WriteLine($"20 ={Fib(20)}"); // 6765
            Console.WriteLine($"30 ={Fib(30)}"); // 832040
            Console.WriteLine($"50 ={Fib(50)}"); // 12586269025
           // Console.WriteLine($"99 ={Fib(99)}"); // 218922995834555169026
           // Console.WriteLine($"100={Fib(100)}"); // 354224848179261915075
        }

// What data structure would you use instead of int to prevent buffer overflow?
        static int Fib(int N) 
         {
             return 0;     
         }
    }
}
