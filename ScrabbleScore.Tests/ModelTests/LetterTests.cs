using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScore.Models;
using System;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class LetterTests
  {
    [TestMethod]
    public void LetterConstructor_CreatesInstanceOfLetter_Letter()
    {
      Letter newLetter = new Letter("Hello");
      Assert.AreEqual(typeof(Letter), newLetter.GetType());
    }
    [TestMethod]
    public void GetUserWord_ReturnUserWord_String()
    {
      string testWord = "Hello";
      Letter newLetter = new Letter(testWord);
      
      string result = newLetter.UserWord;
      
      Assert.AreEqual(testWord, result);
    }
    [TestMethod]
    public void AssignCharArray_AssignsCharArry_Array()
    {
      string testWord = "Hello";
      char[] testCharArray = {'H','E','L','L','O'};
      Letter newLetter = new Letter(testWord);

      char[] result = Letter.AssignCharArray(newLetter.UserWord);

      CollectionAssert.AreEqual(testCharArray, result);
    }

    // public void AssignPoints_ReturnsUserPoints_Int()
    // {
      
    // }

  }
}