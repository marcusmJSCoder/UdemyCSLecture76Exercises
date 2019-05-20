using System;
using System.Collections.Generic;
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
             * * #1- Write a program that reads a text file and displays the number of words.
             */

            var path = @"c:\cSharpFileTest\";
            string text = File.ReadAllText(path + "cSharpTestFile.txt");
            string[] splitStr = text.Split(new[] { "\r\n", "\r", "\n", " " }, StringSplitOptions.None);
            int wordCount = 0;

            foreach (var word in splitStr)
            {
                Console.Write(word + ' ');
                wordCount += 1;
            }
            Console.WriteLine("\nnumber of words: " + wordCount);

            /*
             * 
             */
        }
    }
}
