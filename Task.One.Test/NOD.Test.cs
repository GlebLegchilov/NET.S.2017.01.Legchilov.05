using System;
using System.Collections.Generic;
using NUnit.Framework;
using static Task.One.NOD;
using static Task.One.FloatExtension;

namespace Task.One.Test
{
    [TestFixture]
    public class NODTest
    {
        [TestCase(null)]
        public void GetEuclideanNoD_ThrowArgumentNullException(int[] array)
        {
            TimeSpan time;
            Assert.Throws<ArgumentNullException>(() => GetEuclideanNoD(out time, array));
        }

        [TestCase(new int[] {10, 25, 5}, ExpectedResult = 5)]
        [TestCase(new int[] { 10, 25, 5, -15 }, ExpectedResult = 5)]
        public int GetEuclideanNoD_PositivTest(params int[] array)
        {
            TimeSpan time;
            return GetEuclideanNoD(out time, array);
        }

        [TestCase(null)]
        public void GetBinaryNoD_ThrowArgumentNullException(int[] array)
        {
            TimeSpan time;
            Assert.Throws<ArgumentNullException>(() => GetBinaryNoD(out time, array));
        }

        [TestCase(new int[] { 10, 25, 5 }, ExpectedResult = 5)]
        [TestCase(new int[] { 10, 25, 5, -15 }, ExpectedResult = 5)]
        public int GetBinaryNoD_PositivTest(params int[] array)
        {
            TimeSpan time;
            return GetBinaryNoD(out time, array);
        }

        [TestCase(5.5F, ExpectedResult = "01000000101100000000000000000000")]
        public string GetBinary_PositivTest(float number)
        {
            return Task.One.FloatExtension.GetBinary(number);
        }
    }
}
