using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        
        public void AddGrade(double grade)
        {
           grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = 0.0;
            result.Low = 0.0;
            
            foreach(var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /=grades.Count;

            return result;
        }

        // var result = 0.0;
        //     var highGrade = double.MinValue;
        //     var lowGrade = double.MaxValue;
        //     foreach(var number in grades)
        //     {
        //         highGrade = Math.Max(number, highGrade);
        //         lowGrade = Math.Min(number, lowGrade);
        //         result += number;
        //     }

        //     result /=grades.Count;

        //     Console.WriteLine($"The average grade is {result:N1}");
        //     Console.WriteLine($"The highest grade is {highGrade}");
        //     Console.WriteLine($"The Lowest grade is {lowGrade}");

        private List<double> grades;
        private string name;


    }
}