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
            // anagrams are words that have identical counts of each letter
            // lettercounts can first just be an array of 26 counts [a thru z]
            // we could have a dictionary of array-->list of words with that count,
            // dictionary of  that specific count to a list of words with those counts
            var wordsByCount = new Dictionary< Dictionary<char, int>, List<string> > ();
            foreach (var word in words) // O(n * m)
            {
            var letterCount = getLetterCount( word );   // O( m)
            if ( letterCount.ContainsKey(letterCount) ) count.Add(c, count[c] + 1);
            else letterCount.Add(c,1);
            }
// O(n * m)

// iter dic words by count O(distinct counts * words per count)

// 
            
        }

    static Dictionary<char, int> getLetterCount( string word )
    {
        Dictionary<char, int> count = new Dictionary<char, int>();
        foreach( var c in word)
        {
            if ( count.ContainsKey(c) ) count.Add(c, count[c] + 1);
            else count.Add(c,1);
        }
        return count;
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
