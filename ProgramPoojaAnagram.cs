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
        }

        public static IEnumerable<IEnumerable<string>> GroupAnagrams(IEnumerable<string> strs) 
        {
            //algo goes here
            var result = new List<List<string>>();
            var strList = strs.ToList();
            //string sortedStr = "";
            for(int i=0; i< strList.Count; i++)
            {
                Array.Sort(strList[i].ToCharArray());
                //var res = strList.FindAll(x=> x.Length.Equals(strList[i].Length));
                foreach(var txt in res)
                {
                    Array.Sort(txt.ToCharArray());
                    if(txt.Equals(strList[i]))
                    {
                        result.Add(res);
                    }
                }               
            }
            return result;
        }
        
        static IEnumerable<string> GetWords() => new[]
        {
            "eat", "tea", "tan", "ate", "nat", "bat34"
        };

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
