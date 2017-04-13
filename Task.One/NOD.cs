using System;
using System.Diagnostics;

namespace Task.One
{


    /// <summary>
    /// Class find numbers NOD 
    /// </summary>
    public static class NOD
    {
        private static Func<int[], string, Func<int, int, int>, int> getNod = new Func<int[], string, Func<int, int, int>, int>(delegate (int[] array, string time, Func<int, int, int> del)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int result = del(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
                result = del(result, array[i]);
            timer.Stop();
            time = timer.Elapsed.TotalSeconds.ToString();
            return result;
        });

        #region Euclidean

        /// <summary>
        /// Find numbers NOD by the Euclidean method
        /// </summary>
        /// <param name="time">Execution time</param>
        /// <param name="numberOne">First number</param>
        /// <param name="numberTwo">Second number</param>
        /// <returns>Numbers NOD</returns>
        public static int GetEuclideanNoD(out string time, int numberOne, int numberTwo)
        {
            int[] paramArray = new int[] { numberOne, numberTwo};
            return getNod(paramArray, time = null, NOD.EuclideanNoD);
        }
        /// <summary>
        /// Find numbers NOD by the Euclidean method
        /// </summary>
        /// <param name="time">Execution time</param>
        /// <param name="numberOne">First number</param>
        /// <param name="numberTwo">Second number</param>
        /// <param name="numberThree">Theerd number</param>
        /// <returns>Numbers NOD</returns>
        public static int GetEuclideanNoD(out string time, int numberOne, int numberTwo, int numberThree)
        {
            int[] paramArray = new int[] { numberOne, numberTwo, numberThree };
            return getNod(paramArray, time = null, NOD.EuclideanNoD);
        }
        /// <summary>
        /// Find numbers NOD by the Euclidean method
        /// </summary>
        /// <param name="time">Execution time</param>
        /// <param name="array">Numbers array</param>
        /// <returns>Numbers NOD</returns>
        public static int GetEuclideanNoD(out string time, params int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            return getNod(array, time = null, NOD.EuclideanNoD);
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
                if (numberOne > numberTwo)
                    numberOne = numberOne - numberTwo;
                else 
                    numberTwo = numberTwo - numberOne;
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
        public static int GetBinaryNoD(out string time, int numberOne, int numberTwo)
        {
            int[] paramArray = new int[] { numberOne, numberTwo };
            return getNod(paramArray, time = null, NOD.BinaryNoD);
        }
        /// <summary>
        /// Find numbers NOD by the Euclidean method
        /// </summary>
        /// <param name="time">Execution time</param>
        /// <param name="numberOne">First number</param>
        /// <param name="numberTwo">Second number</param>
        /// <param name="numberThree">Theerd number</param>
        /// <returns>Numbers NOD</returns>
        public static int GetBinaryNoD(out string time, int numberOne, int numberTwo, int numberThree)
        {
            int[] paramArray = new int[] { numberOne, numberTwo, numberThree };
            return getNod(paramArray, time = null, NOD.BinaryNoD);
        }

        /// <summary>
        /// Find numbers NOD by the binary method
        /// </summary>
        /// <param name="time">Execution time</param>
        /// <param name="array">Numbers array</param>
        /// <returns>Numbers NOD</returns>
        public static int GetBinaryNoD(out string time, params int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            return getNod(array, time = null, NOD.BinaryNoD);
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
                if ((numberTwo & 1) != 0)
                    return BinaryNoD(numberOne >> 1, numberTwo);
                else
                    return BinaryNoD(numberOne >> 1, numberTwo >> 1) << 1;
            if ((~numberTwo & 1) != 0)
                return BinaryNoD(numberOne, numberTwo >> 1);
            if (numberOne > numberTwo)
                return BinaryNoD((numberOne - numberTwo) >> 1, numberTwo);
            return BinaryNoD((numberTwo - numberOne) >> 1, numberOne);
        }
        #endregion
    }
}
