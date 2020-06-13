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
            var permutations = FindPermutations(numbers, 0, numbers.Length);
            // print permutations
            showMe(permutations);
        }

        public static IEnumerable<IEnumerable<int>> FindPermutations(int[] nums, int l, int r) 
        {
            var result = new List<IList<int>>();
            // algo goes here
            if (l == r) {
                result.Add(nums);
            }
            for (int i = 0; i < r; i++) {
                result.Add(findPermutation(nums, l, i));
                FindPermutations(nums, l+1, r);
                result.Add(findPermutation(nums, i, r));
            }
            return result;
        }

        public static int[] findPermutation(int[] nums, int a, int b) {
            int temp = nums[b];
            nums[b] = nums[a];
            nums[a] = temp;
            return nums;
        }
        
        static int[] GetNumbers() => new int[]{1,2,3};

         public static void showMe(IEnumerable<IEnumerable<int>> permutations) {
             foreach (IEnumerable<int> permutation in permutations) {
                 foreach (int number in permutation) {
                     Console.Write(number);
                     Console.Write(' ');
                 }
                 Console.WriteLine();
             }
        }
    }
}
