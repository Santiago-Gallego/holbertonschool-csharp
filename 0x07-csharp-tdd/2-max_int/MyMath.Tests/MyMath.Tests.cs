using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Operations_Tests
    {

        [Test]
        public void Max_whenNumsIsEmpty_returnZero()
        {
            List<int> nums = new List<int>();

            int maxVal = Operations.Max(nums);
            Assert.AreEqual(0, maxVal);
        }
        
        [Test]
        public void Max_whenNumsIsNull_returnZero()
        {
            List<int> nums = null;

            int maxVal = Operations.Max(nums);
            Assert.AreEqual(0, maxVal);
        }

        [Test]
        public void Max_whenNums_returnMaxVal()
        {
            List<int> nums = new List<int>();
            nums.Add(2);
            nums.Add(4);
            nums.Add(200);
            nums.Add(-14);

            int maxVal = Operations.Max(nums);
            Assert.AreEqual(200, maxVal);
        }
    }
}