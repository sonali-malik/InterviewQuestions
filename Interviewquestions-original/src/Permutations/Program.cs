using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutations
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Permutations Finder!");
            var numbers = GetNumbers();
            var permutations = FindPermutations(numbers);
            // print permutations
            PrintResult(permutations);
        }

        public static IEnumerable<IEnumerable<int>> FindPermutations(int[] nums) 
        {
            var result = new List<IList<int>>();
            // algo goes here.
            return result;
        }
        
        static int[] GetNumbers() => new int[]{1,2,3};

         public static void PrintResult(IEnumerable<IEnumerable<int>> permutations) 
         {
             // code goes here to print permutations            
         }
    }
}
