using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DulAlgorithmTests
{
    [TestClass]
    public class AlgorithmClassTest
    {
        [TestMethod]
        public void MyTestMethod()
        {
            Assert.AreEqual(10, 100);
        }

        [TestMethod]
        public void SelectionSort_ShouldReturnSortedArray()
        {

            //[1] Arrange, Setup
            int[] arr = { 33, 22, 44 };

            //[2] Act, Excute
            int[] results = DulAlgorithm.Algorithm.SelectionSort(arr);

            //[3] Assert, Verify
            Assert.AreEqual(22, results[0]);
            Assert.AreEqual(33, results[1]);
            Assert.AreEqual(44, results[results.Length -1]);
            
        }
    }
}