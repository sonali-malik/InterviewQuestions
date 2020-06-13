using System;
using System.Collections.Generic;
using System.Linq;

namespace AnagramQuestion
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anagram Finder!");
            var words = GetWords();
            var moreWords = GetMoreWords();
            var groupedAnagramList = GroupAnagrams(words);
            // print groupedAnagramList
        }

        public static IEnumerable<IEnumerable<string>> GroupAnagrams(IEnumerable<string> strs) 
        {
            // algo goes here
            var result = new List<List<string>>();
            return result;
        }
        
        static IEnumerable<string> GetWords() => new[]
        {
            "eat", "tea", "tan", "ate", "nat", "bat"
        };

        static IEnumerable<string> GetMoreWords() => new[]
        {
            "Tar",
            "Arc",
            "Elbow",
            "State",
            "Cider",
            "Dusty",
            "Night",
            "Inch",
            "Brag",
            "Cat",
            "Bored",
            "Save",
            "Angel",
            "Stressed",
            "Rat",
            "Car",
            "Below",
            "Taste",
            "Cried",
            "Study",
            "Thing",
            "Chin",
            "Grab",
            "Act",
            "Robed",
            "Vase",
            "Glean",
            "Desserts"
        };
    }
}
