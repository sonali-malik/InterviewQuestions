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
            Console.WriteLine($"0 ={Fib(0)}");
            Console.WriteLine($"1 ={Fib(1)}");
            Console.WriteLine($"2 ={Fib(2)}");
            Console.WriteLine($"3 ={Fib(3)}");
            Console.WriteLine($"4 ={Fib(4)}");
            Console.WriteLine($"5 ={Fib(5)}");
            Console.WriteLine($"6 ={Fib(6)}");
            Console.WriteLine($"50 ={Fib(50)}");
            Console.WriteLine($"99 ={Fib(99)}");

            
            var result = Fib(100);
            Console.WriteLine($"100={result}");
        }

        static BigInteger Fib(int N) 
        {
            
            if (N-- == 0) return 0;
            if (N-- == 0) return 1;
            BigInteger f1 = 0;
            BigInteger f2 = 1;
            BigInteger res = 0;
            while (N-->= 0) {
                res = f1 + f2;
                f1 = f2;
                f2 = res;
            }
            return res;
        }
    }
}
