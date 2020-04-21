using System;
using System.Collections.Generic;

namespace GradeBook
{


    

    class Program
    {

        static void Main(string[] args)
        {
        
            var book = new Book("David's Grade Book");
            
            
            bool done = false;

                while(!done)
                {
                    Console.WriteLine("Enter a grade or 'q' to quit: ");
                    string input = Console.ReadLine();

                    if (input != "q"){
                        double grade = double.Parse(input);
                        book.AddGrade(grade);
                    } else
                    {
                        done = true;
                        continue;
                    }  
                }

            var stats = book.GetStatistics();

            Console.WriteLine($"The average grade is {stats.Average}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The Lowest grade is {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

         
        }

    }
}
