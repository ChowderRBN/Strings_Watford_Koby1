using System;

class Program
{
    static void Main()
    {
        // Ask for a character input
        Console.Write("Please input a character!\n");
        char myChar = Console.ReadKey().KeyChar;
        bool isLetter = Char.IsLetter(myChar);
        Console.WriteLine($"\n{myChar} is a letter: {isLetter}\n");

        // Ask for a string input
        Console.WriteLine("Why do you like video games?");
        string string1 = Console.ReadLine();

        // Ask for a word to search
        Console.WriteLine("Enter a word");
        string string2 = Console.ReadLine();

        // Check if the word exists in the string
        bool containsWord = string1.Contains(string2);
        Console.WriteLine($"{string2} exists in {string1}, {containsWord}!");
    }
}
