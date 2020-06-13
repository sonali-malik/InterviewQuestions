using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s = new Solution();
            var sqrt0 = s.Sqrt(16D);
            var sqrt1 = s.Sqrt(64D);
            var sqrt2 = s.Sqrt(6D);
            Console.WriteLine($"Sqrt of 16 == {sqrt0}");
            Console.WriteLine($"Sqrt of 64 == {sqrt1}");
            Console.WriteLine($"Sqrt of 6 == {sqrt2}");
        }
    }


    public class Solution
    {
        public double Sqrt(double a)
        {
            double epsilon = 0.001D;
            // Place your algorithm here
            return epsilon;

        }
    }
}
