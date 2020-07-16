using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Word
  {
    public string UserWord { get; }
    private static Dictionary<char, int> _scrabbleLetters = new Dictionary<char,int>(){{'A', 1}, {'B', 3}, {'C', 3}, {'D', 2}, {'E', 1}, {'F', 4}, {'G', 2}, {'H', 4}, {'I', 1}, {'J', 8}, {'K', 5}, {'L', 1}, {'M', 3}, {'N', 1}, {'O', 1}, {'P', 3}, {'Q', 10}, {'R', 1}, {'S', 1}, {'T', 1}, {'U', 1}, {'V', 4}, {'W', 4}, {'X', 8}, {'Y', 4}, {'Z', 10}};

    public Word(string userWord)
    {
      UserWord = userWord;
    }

    public char[] AssignCharArray()
    {
      string upperUserWord = UserWord.ToUpper();
      char[] userArray = upperUserWord.ToCharArray();
      return userArray;
    }
    
    public int AssignPoints()
    {
      int userPoints = 0;
      char[] userArray = AssignCharArray();
      foreach (char letter in userArray)
      {
        userPoints += _scrabbleLetters[letter];
      }
      return userPoints;
    }
  }
}