using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRank
{
    class WarmUp
    {
        #region COMPARE TRIPLETS
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var result = new List<int> { 0, 0 };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    result[0] += 1;
                }
                else if (a[i] < b[i])
                {
                    result[1] += 1;
                }
            }

            return result;

        }
        #endregion

        #region BINARY SEARCH
        public static bool BinarySearch(int[] inputArray, int Value)
        {
            //Sorts array and saves the data in same arrayinput
            Array.Sort(inputArray);

            // Step 1 - intialize the variables
            int fIndex = 0;                             // beginning of the range
            int lIndex = inputArray.Length - 1;         // end of the range

            // Step 2 - we do something (search for our value)
            while (fIndex <= lIndex)                    // when true, we are still in the range           
            {
                int mIndex = (fIndex + lIndex) / 2;     // find the midpoint
                if (inputArray[mIndex] < Value)
                {
                    fIndex = mIndex + 1;                // set fIndex to mid point. We narrowed to 2nd half of the array, Value is greater than the data in slot mIndex
                }
                else if (inputArray[mIndex] > Value)    // the opposite occurs. Value is in the left of the array and set lIndex to mid point
                {
                    lIndex = mIndex - 1;
                }
                else
                {
                    return true;                        // here we found our value b/c inputArray[mIndex] must = Value
                }
            }
            // Step 3 - indicate not found
            return false;
        }
        #endregion

        #region LINEAR SEARCH
        public static int LinearSearch(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region VeryBigSum       
        public static long VeryBigSum(long[] ar)
        {
            long result = 0;

            foreach (var value in ar)
            {
                result += value;
            }

            return result;

        }
        #endregion

        #region diagonalDifference      
        public static int diagonalDifference(List<List<int>> arr)
        {
            var dv1 = 0;
            var dv2 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                //string[] a_temp = Console.ReadLine().Split(' ');
                //a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);

                dv1 += arr[i][i];
                dv2 += arr[i][(arr.Count - 1) - i];
            }

            var result = Math.Abs(dv1 - dv2);

            return result;
        }
        #endregion

        #region plusMinus     
        public static List<float> plusMinus(float[] arr)
        {
            var result = new List<float> { 0, 0, 0 };
            float pos = 0, neg = 0, zer = 0;

            foreach (var item in arr)
            {
                if (item == 0)
                {
                    pos += 1;
                }
                else if (item == 0)
                {
                    neg += 1;
                }
                else
                {
                    zer += 1;
                }
            }

            result[0] = pos / arr.Length;
            result[1] = neg / arr.Length;
            result[2] = zer / arr.Length;

            return result;

        }
        #endregion

        #region * staircase       
        public static void staircase(int n)
        {
            //Solution 1
            for (int i = 0; i < n; i++)
                Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));

            //Solution 2
            /*
            int iN = Convert.ToInt32(Console.ReadLine());
           
            StringBuilder floor = new StringBuilder(iN * iN);
            for (int i = 0; i <= iN; i++)
            {
                floor.Append(' ', iN - i);
                floor.Append('#', i);
                if (iN != i) 
                    floor.Append(Environment.NewLine);
            }
            Console.WriteLine(floor);
            */

        }
        #endregion

        #region MiniMaxSum       
        static void MiniMaxSum(int[] arr)
        {
            var min = 0;
            var max = 0;
            for (var i = 0; i < arr.Length - 1; i++)
            {
                min += arr[i];
            }

            for (var i = 5; i < arr.Length - 1; i--)
            {
                max += arr[i];
            }

            Console.Write($"{min} {max}");

        }
        #endregion

        #region BirthdayCakeCandles      
        static int BirthdayCakeCandles(int[] ar)
        {
            int result = 0;
            var max = ar.Max();

            for (int i = 0; i < ar.Length; i++)
            {
                if (max == ar[i])
                {
                    result += 1;
                }
            }

            return result;

        }
        #endregion

        #region TimeConversion       
        static string TimeConversion(string s)
        {
            string time = "";

            if (s.Substring(8, 2) == "AM")
            {
                if (s.Substring(0, 2) == "12")
                {
                    return "00" + s.Substring(2, 6);
                }
                else
                {
                    return s.Substring(0, 8);
                }
            }
            else if (s.Substring(8, 2) == "PM")
            {
                if (s.Substring(0, 2) == "12")
                {
                    return "12" + s.Substring(2, 6);
                }
                else
                {
                    int con = Convert.ToInt32(s.Substring(0, 2)) + 12;

                    return Convert.ToString(con) + s.Substring(2, 6);
                }
            }
            return time;

        }
        #endregion
    }
}
