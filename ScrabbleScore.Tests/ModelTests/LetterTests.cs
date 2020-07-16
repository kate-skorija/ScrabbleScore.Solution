using System;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class LetterTests
  {
    [TestMethod]
    public void LetterConstructor_CreatesInstanceOfLetter_Letter()
    {
      Letter newLetter = new Letter();
      Assert.AreEqual(typeof(Letter), newLetter.GetType());
    }
  }
}