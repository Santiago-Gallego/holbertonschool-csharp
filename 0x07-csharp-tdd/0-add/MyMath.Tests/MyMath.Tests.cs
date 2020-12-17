using NUnit.Framework;

namespace MyMath.Tests
{
    ///<summary> represents the tests for Operations Class </summary>
    [TestFixture]
    public class Operations_Tests
    {
        /// <sumary> test Add method from MyMath Class </sumary>
        [Test]
        [TestCase(5, 10)]
        [TestCase(-5, 8)]
        [TestCase(0, 4)]
        [TestCase(1000, 2)]
        [TestCase(0, 0)]
        [TestCase(-4, -10)]
        public void Add_whenTwoNumbersPassed_ReturnsSumResult(int a, int b)
        {
            int result = Operations.Add(a, b);
            Assert.AreEqual(a + b, result);
        }
    }
}