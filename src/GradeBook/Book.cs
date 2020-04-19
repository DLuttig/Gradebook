using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        
        public void AddGrade (double grade)
        {
           grades.Add(grade);
        }

        public void ShowStatistics ()
        {

            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach(var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            result /=grades.Count;

            Console.WriteLine($"The average grade is {result:N1}");
            Console.WriteLine($"The highest grade is {highGrade}");
            Console.WriteLine($"The Lowest grade is {lowGrade}");
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