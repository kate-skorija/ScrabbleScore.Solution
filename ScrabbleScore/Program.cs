using System;
using ScrabbleScore.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("Scrabble me up a word!");
    string userInput = Console.ReadLine();

    Word gameWord = new Word(userInput);
    int points = gameWord.AssignPoints();

    Console.WriteLine("That word has earned you: " + points + " points");
  }
}