using System;
using System.Text.RegularExpressions;
class Program {
    static void Main(string[] args){
        Console.WriteLine("Please enter a string: ");
        string? word = Console.ReadLine().Trim();
        string input = Regex.Split(word, @"\s+")[0];
        string reversed = "";
        foreach (char c in input){
            if (char.IsLetter(c)){
                reversed = c + reversed;
            }
        }
        if (input.ToLower() == reversed.ToLower()){
            Console.WriteLine("This is a palindrome!");
        } else {
            Console.WriteLine("This is not a palindrome!");
        }
    }
}