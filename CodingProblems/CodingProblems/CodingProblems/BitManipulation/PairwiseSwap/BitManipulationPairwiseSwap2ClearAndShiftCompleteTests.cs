﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingProblems.BitManipulation.PairwiseSwap
{
    /// <summary>
    /// Tests BitManipulationPairwiseSwap2ClearAndShiftComplete.PairwiseSwap
    /// </summary>
    [TestClass]
    public class BitManipulationPairwiseSwap2ClearAndShiftCompleteTests
    {
        /// <summary>
        /// Tests BitManipulationPairwiseSwap2ClearAndShiftComplete.SwapOddEvenBits simple test.
        /// </summary>
        [TestMethod]
        public void BitManipulationPairwiseSwap2ClearAndShiftCompleteTest1()
        {
            var expected = Convert.ToInt32("10", 2);
            var actual = BitManipulationPairwiseSwap2ClearAndShiftComplete.SwapOddEvenBits(Convert.ToInt32("1", 2));
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationPairwiseSwap2ClearAndShiftComplete.SwapOddEvenBits simple test.
        /// </summary>
        [TestMethod]
        public void BitManipulationPairwiseSwap2ClearAndShiftCompleteTest2()
        {
            var expected = Convert.ToInt32("1101", 2);
            var actual = BitManipulationPairwiseSwap2ClearAndShiftComplete.SwapOddEvenBits(Convert.ToInt32("1110", 2));
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests BitManipulationPairwiseSwap1BruteForceComplete.SwapOddEvenBits test with multiple bits to set/clear.
        /// </summary>
        [TestMethod]
        public void BitManipulationPairwiseSwap2ClearAndShiftCompleteTest3()
        {
            var original = Convert.ToInt32("10101010101010101010101010101010", 2);
            var expected = Convert.ToInt32("01010101010101010101010101010101", 2);

            // Swap
            var actual = BitManipulationPairwiseSwap2ClearAndShiftComplete.SwapOddEvenBits(original);
            Assert.AreEqual(expected, actual);

            // Swap back.
            var actual2 = BitManipulationPairwiseSwap2ClearAndShiftComplete.SwapOddEvenBits(actual);
            Assert.AreEqual(actual2, original);
        }
    }
}
