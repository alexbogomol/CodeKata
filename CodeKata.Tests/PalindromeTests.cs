using CodeKata.Palindrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKata.Tests
{
    [TestClass]
    public class PalindromeTests
    {
        //private readonly IPalindromeDetector _sut = new EmpiricIterationDetector();
        //private readonly IPalindromeDetector _sut = new MutableRecursionDetector();
        //private readonly IPalindromeDetector _sut = new ImmutableRecursionDetector();
        private readonly IPalindromeDetector _sut = new ReversedMirrorIterationDetector();

        [TestMethod]
        public void IsEvenPalindrome()
        {
            var actual = _sut.IsPalindrome("asdfgfdsa");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsOddPalindrome()
        {
            var actual = _sut.IsPalindrome("asdffdsa");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsNotAPalindrome()
        {
            var actual = _sut.IsPalindrome("qwertyuiop[]");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EmptyIsAPalindrome()
        {
            var actual = _sut.IsPalindrome("");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SingleIsAPalindrome()
        {
            var actual = _sut.IsPalindrome("q");

            Assert.IsTrue(actual);
        }
    }
}
