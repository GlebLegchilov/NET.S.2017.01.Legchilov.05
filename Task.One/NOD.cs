using System;
using System.Diagnostics;

namespace Task.One
{
    /// <summary>
    /// Class find numbers NOD 
    /// </summary>
    public static class NOD
    {
        #region Euclidean

        /// <summary>
        /// Find numbers NOD by the Euclidean method
        /// </summary>
        /// <param name="time">Execution time</param>
        /// <param name="numberOne">First number</param>
        /// <param name="numberTwo">Second number</param>
        /// <returns>Numbers NOD</returns>
        public static int GetEuclideanNoD(out TimeSpan time, int numberOne, int numberTwo)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = EuclideanNoD(numberOne, numberTwo);
            timer.Stop();
            time = timer.Elapsed;
            return result;
        }
        /// <summary>
        /// Find numbers NOD by the Euclidean method
        /// </summary>
        /// <param name="time">Execution time</param>
        /// <param name="array">Numbers array</param>
        /// <returns>Numbers NOD</returns>
        public static int GetEuclideanNoD(out TimeSpan time, params int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = EuclideanNoD(array[0], array[1]);
            for(int i = 2; i< array.Length; i++)
                result = EuclideanNoD(result, array[i]);
            timer.Stop();
            time = timer.Elapsed;
            return result;
        }

        /// <summary>
        /// Find NOD of two numbers by the Euclidean method
        /// </summary>
        /// <param name="numberOne">Number one</param>
        /// <param name="numberTwo">Number two</param>
        /// <returns>Numbers NOD</returns>
        private static int EuclideanNoD(int numberOne, int numberTwo)
        {
            numberOne = Math.Abs(numberOne);
            numberTwo = Math.Abs(numberTwo);
            while (numberOne != numberTwo)
            {
                if (numberOne > numberTwo)
                {
                    numberOne = numberOne - numberTwo;
                }
                else {
                    numberTwo = numberTwo - numberOne;
                }
            }
            return numberOne;
        }
        #endregion

        #region Binary

        /// <summary>
        /// Find numbers NOD by the binary method
        /// </summary>
        /// <param name="time">Execution time</param>
        /// <param name="numberOne">First number</param>
        /// <param name="numberTwo">Second number</param>
        /// <returns>Numbers NOD</returns>
        public static int GetBinaryNoD(out TimeSpan time, int numberOne, int numberTwo)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = BinaryNoD(numberOne, numberTwo);
            timer.Stop();
            time = timer.Elapsed;
            return result;
        }

        /// <summary>
        /// Find numbers NOD by the binary method
        /// </summary>
        /// <param name="time">Execution time</param>
        /// <param name="array">Numbers array</param>
        /// <returns>Numbers NOD</returns>
        public static int GetBinaryNoD(out TimeSpan time, params int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = BinaryNoD(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
                result = BinaryNoD(result, array[i]);
            timer.Stop();
            time = timer.Elapsed;
            return result;
        }

        /// <summary>
        /// Find NOD of two numbers by the binary method
        /// </summary>
        /// <param name="numberOne">Number one</param>
        /// <param name="numberTwo">Number two</param>
        /// <returns>Numbers NOD</returns>
        private static int BinaryNoD(int numberOne, int numberTwo)
        {
            numberOne = Math.Abs(numberOne);
            numberTwo = Math.Abs(numberTwo);
            if (numberOne == numberTwo)
                return numberOne;
            if (numberOne == 0)
                return numberTwo;
            if (numberTwo == 0)
                return numberOne;
            if ((~numberOne & 1) != 0)
            {
                if ((numberTwo & 1) != 0)
                    return BinaryNoD(numberOne >> 1, numberTwo);
                else
                    return BinaryNoD(numberOne >> 1, numberTwo >> 1) << 1;
            }
            if ((~numberTwo & 1) != 0)
                return BinaryNoD(numberOne, numberTwo >> 1);
            if (numberOne > numberTwo)
                return BinaryNoD((numberOne - numberTwo) >> 1, numberTwo);
            return BinaryNoD((numberTwo - numberOne) >> 1, numberOne);
        }
        #endregion
    }
}
