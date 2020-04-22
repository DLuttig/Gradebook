using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("David's Grade Book");
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded += OnGradeAdded;
            book.GradeAdded -= OnGradeAdded;
            book.GradeAdded += OnGradeAdded;

            bool done = false;
                while(!done)
                {
                    Console.WriteLine("Enter a grade or 'q' to quit: ");
                    string input = Console.ReadLine();

                    if (input != "q"){
                        try
                        {
                            double grade = double.Parse(input);
                            book.AddGrade(grade);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            Console.WriteLine("**");
                        }

                    } else
                    {
                        done = true;
                        continue;
                    }  
                }

            var stats = book.GetStatistics();

            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The average grade is {stats.Average}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The Lowest grade is {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}");

         
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade has been added");
        }

    }
}
