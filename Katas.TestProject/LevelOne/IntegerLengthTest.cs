using Katas.LevelOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Katas.TestProject.LevelOne
{
    [TestClass]
    public class IntegerLengthTest
    {
        [TestMethod]
        public void NegativeNumber()
        {
            IntegerLength integerLengthCounter = new IntegerLength();
            integerLengthCounter.CountIntegerDigits(-20);
        }

        [TestMethod]
        public void FourDigits()
        {
            IntegerLength integerLengthCounter = new IntegerLength();
            var count = integerLengthCounter.CountIntegerDigits(1235);
            Assert.AreEqual(4, count);
        }

        [TestMethod]
        public void SevenDigits()
        {
            IntegerLength integerLengthCounter = new IntegerLength();
            var count = integerLengthCounter.CountIntegerDigits(1234567);
            Assert.AreEqual(7, count);
        }

        [TestMethod]
        public void LongDigits()
        {
            IntegerLength integerLengthCounter = new IntegerLength();
            var count = integerLengthCounter.CountIntegerDigits(999999999);
            Assert.AreEqual(9, count);
        }
    }
}