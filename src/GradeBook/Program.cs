using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = new DiskBook("David's Grade Book");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);
       
            var stats = book.GetStatistics();

            Console.WriteLine(InMemoryBook.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The average grade is {stats.Average}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The Lowest grade is {stats.Low}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
             while(true)
                {
                    Console.WriteLine("Enter a grade or 'q' to quit: ");
                    string input = Console.ReadLine();

                    if (input == "q")
                    {
                        break;
                    }

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
                }
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("A grade has been added");
        }

    }
}
