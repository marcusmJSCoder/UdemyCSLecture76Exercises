using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCSLecture76Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Marcus Mayo
             * 5/19/2019
             * 
             * #1- Write a program that reads a text file and displays the number of words.
             */

            //var path = @"c:\cSharpFileTest\";
            //string text = File.ReadAllText(path + "cSharpTestFile.txt");
            //string[] splitStr = text.Split(new[] { "\r\n", "\r", "\n", " " }, StringSplitOptions.None);
            //int wordCount = 0;

            //foreach (var word in splitStr)
            //{
            //    Console.Write(word + ' ');
            //    wordCount += 1;
            //}
            //Console.WriteLine("\nnumber of words: " + wordCount);

            /*
             * Marcus Mayo
             * 5/19/2019
             * 
             * #2- Write a program that reads a text file and displays the longest word in the file.
             */

            // 1. access and read file
            // 2. split words
            // 2. find longest word
            // 3. display longest word

            var path = @"C:\cSharpFileTest\LongestWordFile.txt";
            var text = File.ReadAllText(path).Split(' ');
            int longestWord = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i + 1].Length > text[longestWord].Length)
                {
                    longestWord = i + 1;
                }
            }
            Console.WriteLine("The longest word in the file is: " + text[longestWord]);

        }
    }
}
