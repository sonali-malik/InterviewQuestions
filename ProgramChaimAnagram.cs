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
            var anagramList = GroupAnagrams(words);
            showMe(anagramList);
            anagramList = GroupAnagrams(moreWords);
            showMe(anagramList);

        }

        public static void showMe(IEnumerable<IEnumerable<string>> anagrams) {
            foreach( var l in anagrams) {
                Console.Write('[');
                foreach( var s in l) {
                    Console.Write(s);
                    Console.Write(", ");
                }
                Console.WriteLine(']');
            }
        }

        public static IEnumerable<IEnumerable<string>> GroupAnagrams(IEnumerable<string> strs) 
        {
            //algo goes here
            var anagams = new Dictionary<string, List<string>>();
            foreach(var word in strs) {
                var key = String.Concat(word.ToLower().OrderBy(c => c));
                anagams.TryGetValue(key, out var wordlist);
                if (null == wordlist) {
                    wordlist = new List<string>();
                    anagams.Add(key, wordlist);
                }
                wordlist.Add(word);
            }

            var result = new List<List<string>>();
            foreach(var val in anagams.Values) {
                result.Add(val);
            }
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
