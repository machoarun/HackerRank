using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class Implementation
    {
        public static int[] breakingRecords(int[] scores)
        {

            if (scores.Length == 0)
            {
                return new int[2];
            }

            int max = scores[0];
            int min = scores[0];
            int highestcount = 0;
            int lowestcount = 0;
            int[] result = new int[2];

            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                    highestcount++;
                }
                else if (scores[i] < min)
                {
                    min = scores[i];
                    lowestcount++;
                }
            }

            result[0] = highestcount;
            result[1] = lowestcount;

            return result;

        }

        public static int Birthday(List<int> s, int d, int m)
        {
            if (s.Count == 0)
            {
                return 0;
            }

            int result = 0;

            for (int i = 0; i < s.Count - m + 1; i++)
            {
                int Sum = 0;
                for (int j = 0; j < m; j++)
                {
                    Sum += s[i + j];
                }
                if (Sum == d)
                    result++;
            }

            return result;

        }

        public static int[] SqrtArray(int[] input)
        {
            if (input.Length == 0)
                return new int[input.Length];

            int left = 0;
            int right = input.Length - 1;
            int[] output = new int[input.Length];

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[right] > Math.Abs(input[left]))
                {
                    output[i] = input[right] * input[right];
                    right++;
                }
                else
                    output[i] = input[left] * input[left];
                    left++;
            }


            return output;
        }

        public static int[] LongestSubArray(int[] input, int sum)
        {
            if (input.Length == 0 || sum == 0)
                return new int[input.Length];

            int s = 0;
            int left = 0;
            int right = 0;
            int[] result = new int[] { -1 };

            while (right < input.Length)
            {
                s += input[right];
                if (s == sum && result.Length == 1 || result[1] - result[0] > right - left)
                {
                    result = new int[] { left + 1, right + 1 };
                }
                right++;

                while (left < right && s > sum)
                {
                    s -= input[left++];
                }
            }

            return result;
        }
    }
}
