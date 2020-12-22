using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void CamelCase_WhenStrinEmpty_returnsZero()
        {
            string s = "";
            var result = Str.CamelCase(s);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_WhenStrinNull_returnsZero()
        {
            string s = null;
            var result = Str.CamelCase(s);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_WhenStrinFull_returnsNumberOfWords()
        {
            string s = "beWhereYouWannaBe";
            var result = Str.CamelCase(s);
            Assert.AreEqual(5, result);
        }
    }
}