using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.One
{
    /// <summary>
    /// Class find numbers NOD 
    /// </summary>
    public static class NOD
    {
        /// <summary>
        /// Find numbers NOD by the Euclidean method
        /// </summary>
        /// <param name="array">Numbers array</param>
        /// <returns>Numbers NOD</returns>
        public static int GetEuclideanNoD(params int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            int result = EuclideanNoD(array[0], array[1]);
            for(int i = 2; i< array.Length; i++)
                result = EuclideanNoD(result, array[i]);
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

        /// <summary>
        /// Find numbers NOD by the binary method
        /// </summary>
        /// <param name="array">Numbers array</param>
        /// <returns>Numbers NOD</returns>
        public static int GetBinaryNoD(params int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            int result = BinaryNoD(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
                result = BinaryNoD(result, array[i]);
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
    }
}
