using NUnit.Framework;
using TwoSum;

namespace Tests
{
    public class TwoSumUnitTest
    {

        [Test]
        public void Test1()
        {
            var nums = new[] {2, 7, 11, 15};
            var target = 9;
            var outPut = new[] { 0,1};
            
            
            Assert.AreEqual(TwoSumAlgo.Solution(nums,target),outPut);
        }
    }
}