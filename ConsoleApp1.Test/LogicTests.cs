using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplicationTable;
using System.Collections.Generic;

namespace MultiplicationTable.Tests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void MultiplicationTable7Test()
        {
            var expected = new List<string>
            {
                "1 x 7 = 7",
                "2 x 7 = 14",
                "3 x 7 = 21",
                "4 x 7 = 28",
                "5 x 7 = 35",
                "6 x 7 = 42",
                "7 x 7 = 49",
                "8 x 7 = 56",
                "9 x 7 = 63"
            };
            
            var result = Logic.GenerateMultiplicationTable(7);
            CollectionAssert.AreEqual(expected, result);
        }
        
        [TestMethod]
        public void MultiplicationTable5Test()
        {
            var expected = new List<string>
            {
                "1 x 5 = 5",
                "2 x 5 = 10",
                "3 x 5 = 15",
                "4 x 5 = 20",
                "5 x 5 = 25",
                "6 x 5 = 30",
                "7 x 5 = 35",
                "8 x 5 = 40",
                "9 x 5 = 45"
            };
            
            var result = Logic.GenerateMultiplicationTable(5);
            CollectionAssert.AreEqual(expected, result);
        }
        
        [TestMethod]
        public void MultiplyTest()
        {
            Assert.AreEqual(63, Logic.Multiply(9, 7));
            Assert.AreEqual(14, Logic.Multiply(2, 7));
            Assert.AreEqual(7, Logic.Multiply(1, 7));
        }
        
        [TestMethod]
        public void CustomRangeTest()
        {
            var expected = new List<string>
            {
                "3 x 7 = 21",
                "4 x 7 = 28",
                "5 x 7 = 35"
            };
            
            var result = Logic.GenerateMultiplicationTable(7, 3, 5);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}