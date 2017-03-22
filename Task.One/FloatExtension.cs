using System;
using System.Collections.Generic;


namespace Task.One
{
    /// <summary>
    /// Class find binary representation of float
    /// </summary>
    public static class FloatExtension
    {
        /// <summary>
        /// Find binary representation of float
        /// </summary>
        /// <param name="number">Float number</param>
        /// <returns>Binary view</returns>
        public static string GetBinary(this float number)
        {
            const byte bit = 8;
            int[] result = new int[32];
            var byteArray = BitConverter.GetBytes(number);
            int index, temp;

            for (int i = 3; i >= 0; i--)
            {
                index = bit * i;
                while (byteArray[i] > 0)
                {
                    temp = byteArray[i] % 2;
                    byteArray[i] = (byte)(byteArray[i] / 2);
                    if (temp == 1) result[index] = 1;
                    index++;
                }
            }
            return Reverse(String.Concat<int>(result));
        }
        /// <summary>
        /// Reverse string
        /// </summary>
        /// <param name="s">Old string</param>
        /// <returns>New string</returns>
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
