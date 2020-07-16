using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("Hello");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }
    [TestMethod]
    public void GetUserWord_ReturnUserWord_String()
    {
      string testWord = "Hello";
      Word newWord = new Word(testWord);
      
      string result = newWord.UserWord;
      
      Assert.AreEqual(testWord, result);
    }
    [TestMethod]
    public void AssignCharArray_AssignsCharArry_Array()
    {
      string testWord = "Hello";
      char[] testCharArray = {'H','E','L','L','O'};
      Word newWord = new Word(testWord);
      char[] result = newWord.AssignCharArray();
      CollectionAssert.AreEqual(testCharArray, result);
    }
    [TestMethod]
    public void AssignPoints_ReturnsUserPoints_Int()
    {
      string testWord = "Hello";
      int testPoints = 8;
      Word newWord = new Word(testWord);

      char[] resultArray = newWord.AssignCharArray();
      int userPoints = newWord.AssignPoints();

      Assert.AreEqual(testPoints, userPoints);
    }

  }
}