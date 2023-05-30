using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjCharGenerator;
using System.IO;

namespace ProjCharGenerator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int wordsCount = 100;
            Program.ToFile(new GenericGeneration("Bigramm"), "../../../../lab-05-test/Bigramm.txt", wordsCount);
            string[] words = File.ReadAllText("Bigramm.txt").Split(new char[] { ' ', '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(words.Length, wordsCount);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int wordsCount = 10000;
            Program.ToFile(new GenericGeneration("Bigramm"), "Bigramm.txt", wordsCount);
            string[] words = File.ReadAllText("Bigramm.txt").Split(new char[] { ' ', '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(words.Length, wordsCount);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int wordsCount = 100;
            Program.ToFile(new GenericGeneration("Text"), "Text.txt", wordsCount);
            string[] words = File.ReadAllText("Text.txt").Split(new char[] { ' ', '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(words.Length, wordsCount);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int wordsCount = 10000;
            Program.ToFile(new GenericGeneration("Text"), "Text.txt", wordsCount);
            string[] words = File.ReadAllText("Text.txt").Split(new char[] { ' ', '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(words.Length, wordsCount);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int wordsCount = 100;
            Program.ToFile(new GenericGeneration("PairWord"), "PairWordText.txt", wordsCount);
            string[] words = File.ReadAllText("PairWordText.txt").Split(new char[] { ' ', '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(words.Length, 2 * wordsCount);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int wordsCount = 10000;
            Program.ToFile(new GenericGeneration("PairWord"), "PairWordText.txt", wordsCount);
            string[] words = File.ReadAllText("PairWordText.txt").Split(new char[] { ' ', '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(words.Length, 2 * wordsCount);
        }
    }
}
