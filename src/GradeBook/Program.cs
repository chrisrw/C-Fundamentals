using System;
using System.Collections.Generic;
using GradeBook;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("My New Book");
            book.AddGrade(89.1);
            book.AddGrade(82.1);
            book.AddGrade(77.3);
            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The lowest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Average:N1}");

        }
    }
}
