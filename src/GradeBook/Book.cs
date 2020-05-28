using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        // Method
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                AddGrade(90);
                break;
                case 'B':
                AddGrade(80);
                break;
                case 'C':
                AddGrade(70);
                break;
                case 'D':
                AddGrade(60);
                break;
                case 'F':
                AddGrade(50);
                break;
                default:
                AddGrade(0)
            }
        }

        public void AddGrade(double grade)
        {
            if(grade == 90.0)
            {

            }
            if(grade <= 100 && grade >= 0)
            {
                 grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }


        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

         public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            for(var index = 0; index < grades.Count; index +=1)
            {
                if(grades[index] == 42.1)
                {
                    break;
                }
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
            };
            result.Average /= grades.Count;
            return result;
        }
        // Field
        private List<double> grades;
        public string Name;
    }
}