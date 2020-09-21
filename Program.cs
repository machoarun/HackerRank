using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            #region WarmUp 

            #region COMPARE TRIPLETS

            //List<int> a = new List<int> { 6, 8, 12 };
            //List<int> b = new List<int> { 7, 9, 15 };


            //var result = WarmUp.CompareTriplets(a,b);

            //Console.WriteLine($"compareTriplet: {result[0]}, {result[1]}");
            //Console.ReadKey();

            #endregion

            #region MINIMAXSUM

            //int[] arr = new int[] { 256741038, 623958417, 467905213, 714532089, 938071625 };
            //Int64 sum = 0;
            //var minValue = arr.Min();
            //var maxValue = arr.Max();

            //for (var i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}

            //Console.Write($"{sum - maxValue} {sum - minValue}");
            //Console.ReadKey();

            #endregion

            #region GRADINGSTUDENTS

            //List<int> grades = new List<int> { 44, 84, 94, 21, 0, 18, 100, 18, 62, 30, 61, 53, 0, 43, 2 , 29, 53, 61, 40, 14};
            //var result = Strings.gradingStudents(grades);
            //foreach (var grade in result)
            //{
            //    Console.WriteLine(grade);
            //}

            //Console.ReadKey();


            #endregion

            #region COUNT APPLES AND ORANGES
            //int s = 7;
            //int t = 11;           
            //int a = 5;
            //int b = 15;

            //int[] apples = { -2, 2, 1};
            //int[] oranges = { 5, -6};

            //Strings.countApplesAndOranges(s, t, a, b, apples, oranges);
            #endregion

            #region BINARY SEARCH

            //int theValue = 43;
            //int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            //WriteLine("Our array contains: ");
            //Array.ForEach(array, x => Write(x + " "));

            //Write($"\n\nThe result of a binary search for {theValue} is: ");
            //WriteLine(WarmUp.BinarySearch(array, theValue));

            #endregion

            #region LINEAR SEARCH

            //int theValue = 43;
            //int[] array = new int[] { 11, 22, 43, 54, 57, 59, 62, 78 };

            //WriteLine("Our array contains: ");
            //Array.ForEach(array, x => Write(x + " "));

            //Write($"\n\nThe result of a Linear Search for {theValue} is: ");
            //WriteLine(WarmUp.LinearSearch(array, theValue));

            #endregion

            #endregion

            #region Implementation

            #region Breaking the Records
            //TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            //;
            //int[] result = Implementation.breakingRecords(scores);

            //textWriter.WriteLine(string.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();


            #endregion

            #region Birthday Chocolate
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            //string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            //int d = Convert.ToInt32(dm[0]);

            //int m = Convert.ToInt32(dm[1]);

            //int result = Implementation.Birthday(s, d, m);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
            #endregion

            #endregion

            ReadKey();
        }
    }
}
