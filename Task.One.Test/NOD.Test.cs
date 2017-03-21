using System;
using NUnit.Framework;
using static Task.One.NOD;

namespace Task.One.Test
{
    [TestFixture]
    public class NODTest
    {
        [TestCase(null)]
        public void GetEuclideanNoD_ThrowArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => GetEuclideanNoD(array));
        }

        [TestCase(new int[] {10, 25, 5}, ExpectedResult = 5)]
        [TestCase(new int[] { 10, 25, 5, -15 }, ExpectedResult = 5)]
        public int GetEuclideanNoD_PositivTest(params int[] array)
        {
            return GetEuclideanNoD(array);
        }

        [TestCase(null)]
        public void GetBinaryNoD_ThrowArgumentNullException(int[] array)
        {
            Assert.Throws<ArgumentNullException>(() => GetBinaryNoD(array));
        }

        [TestCase(new int[] { 10, 25, 5 }, ExpectedResult = 5)]
        [TestCase(new int[] { 10, 25, 5, -15 }, ExpectedResult = 5)]
        public int GetBinaryNoD_PositivTest(params int[] array)
        {
            return GetBinaryNoD(array);
        }
    }
}
