using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void IsPalindrome_whenIsPalindrome_returnsTrue()
        {
            bool isP = Str.IsPalindrome("Anita lava la tina");
            Assert.IsTrue(isP);
        }

        [Test]
        public void IsPalindrome_whenIsNotPalindrome_returnsFalse()
        {
            bool isP = Str.IsPalindrome("Laura");
            Assert.IsFalse(isP);
        }

        [Test]
        public void IsPalindrome_whenStringEmpty_returnsTrue()
        {
            bool isP = Str.IsPalindrome("");
            Assert.IsTrue(isP);
        }
    }
}