using System;
using System.Collections.Generic;


namespace Iteration1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] testscores = { 98, 99, 85, 70, 86, 34, 81, };

            //for (int i = 0; i < testscores.Length; i++)
            //{
            //    if (testscores[i] > 85)
            //    {
            //        Console.WriteLine("Passing testscore: " + testscores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Jessy", "Bob", "Adam", "Daniel" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    //if (names[j] == "Jessy")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(97);
            //testScores.Add(81);
            //testScores.Add(72);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }
            //    Console.ReadLine();
            //}

            //List<string> names = new List<string>() { "Jessy", "Bob", "Adam", "Daniel" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 85, 70, 86, 34, 81 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
