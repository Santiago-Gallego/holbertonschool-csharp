using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class UniqueTests
    {

        [Test]
        public void Unique_whenStringNull_retunsMinusOne()
        {
            string s = null;
            var result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Unique_whenStringEmpty_retunsMinusOne()
        {
            string s = "";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Unique_whenStringUniqueChar_retunsIndexOfFirstUniqueChar()
        {
            string s = "iwssisr";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(1, result);
        }
        
        [Test]
        public void Unique_whenStringNonUniqueChar_retunsMinusOne()
        {
            string s = "iwssisrwr";
            var result = Str.UniqueChar(s);
            Assert.AreEqual(-1, result);
        }
    }
}