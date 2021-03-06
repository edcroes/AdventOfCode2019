﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AoC2019.Tests
{
    [TestClass]
    public abstract class DayTestsBase<T> where T : IMDay, new()
    {
        private readonly string _expectedAnswerPart1;
        private readonly string _expectedAnswerPart2;
        private readonly IMDay _dayToTest = new T();

        public DayTestsBase(string expectedAnswerPart1, string expectedAnswerPart2)
        {
            _expectedAnswerPart1 = expectedAnswerPart1;
            _expectedAnswerPart2 = expectedAnswerPart2;
        }

        [TestMethod]
        public void Part1Test()
        {
            var answerPart1 = _dayToTest.GetAnswerPart1();
            Assert.AreEqual(_expectedAnswerPart1, answerPart1);
        }

        [TestMethod]
        public void Part2Test()
        {
            var answerPart2 = _dayToTest.GetAnswerPart2();
            Assert.AreEqual(_expectedAnswerPart2, answerPart2);
        }
    }
}
