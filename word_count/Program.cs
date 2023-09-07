using System;
using System.Text.RegularExpressions;

class Program{
    static void Main(string[] args){
        
        Console.WriteLine("Please enter a string: ");
        string? input = Console.ReadLine().Trim();
        Dictionary<string, int> word_count = new Dictionary<string, int>();
        string[] words = Regex.Split(input, @"\W+");
        foreach (string word in words){
            if (word_count.ContainsKey(word.ToLower())){
                word_count[word.ToLower()]++;
            } else {
                word_count.Add(word.ToLower(), 1);
            }
        }
        
        foreach (KeyValuePair<string, int> word in word_count){
            Console.WriteLine(word.Key + ": " + word.Value);
        }

    }
}

