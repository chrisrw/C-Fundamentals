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
            book.GradeAdded += OnGradeAdded;

         
            var done = false;

            while(!done)
            {   
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if(input == "q")
                {
                    break;
                }
                try {
                var grade = double.Parse(input);
                book.AddGrade(grade); 
                }
                // Catch any type of exception
                catch(ArgumentException ex) {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally{
                    // Console.WriteLine("**") Always Runs
                }
                
            }

            book.AddGrade(89.1);
            book.AddGrade(82.1);
            book.AddGrade(73.3);
            var stats = book.GetStatistics();

            // Const accessed through the class, not that state
            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

        }
        static void OnGradeAdded(object sender, EventArgs e)
        {

        }
    }
}
