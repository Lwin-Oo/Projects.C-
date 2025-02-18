﻿// See https://aka.ms/new-console-template for more information
using System;

namespace GradeBook
{
    class Program
    {
        public static string Lwin { get; private set; }

        static void Main(string[] args)
        {
            var book = new Book(Lwin);
            
            while(true)
            {
                Console.WriteLine("Enter a grade or press 'q' to quit");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }

                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
           var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }     

    }
}

