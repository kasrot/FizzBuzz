
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
    /// <summary>
    /// This class provides various test scenerios to 
    /// test the computation of FizzBuzz
    /// </summary>
    [TestClass]
    public class FizzBuzzTest
    {
        //To test the Fizz 
        [TestMethod]
        public void TestFizz()
        {
            int[] testData =new int[] {3,6,9,12,18,21,24,27,33};
            foreach(int i in testData)
            {
                Assert.AreEqual("Fizz",Program.FizzBuzz(i));
            }
        }
        //To test the Buzz
        [TestMethod]
        public void TestBuzz()
        {
            int[] testData = new int[] {-5,5,10,20,25,35,40 };
            foreach (int i in testData)
            {
                Assert.AreEqual("Buzz", Program.FizzBuzz(i));
            }
        }
        //To test the FizzBuzz
        [TestMethod]
        public void TestFizzBuzz()
        {
            int[] testData = new int[] {0,15,30,45,60,75,90};
            foreach (int i in testData)
            {
                Assert.AreEqual("FizzBuzz", Program.FizzBuzz(i));
            }
        }
        //To test the non FizzBuzz values such as 1,4, etc. 
        [TestMethod]
        public void TestNonFizzValue()
        {
            int[] testData = new int[] {1,2,4,7,11,13,16};
            foreach (int i in testData)
            {
                Assert.AreEqual(i.ToString(), Program.FizzBuzz(i));
            }
        }

    }
}
