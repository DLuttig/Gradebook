using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {

        static void Main(string[] args)
        {
            
            double x = 34.1;
            double y = 10.3;
            double result = x + y;
            Console.WriteLine(result);

            double [] numbers = new double [3];
            numbers[0] = 12.7;
            numbers[1] = 10.3;
            numbers[2] = 6.11;

            double result2 = numbers[0];

            result2 = result2 + numbers [1];

            Console.WriteLine(result2);

             double [] set3 = {12.7, 10.3, 6.11};

            double result3 = set3[0];
            result3 += set3[1];
            result3 += set3[2];
            Console.WriteLine(result3);

            double result4 = 0.0;

            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);

            

            foreach (double number in grades)
            {   
                result4 += number;
            }
            Console.WriteLine(grades.Count);
            double avarageResult = result4 /grades.Count;
            Console.WriteLine($"{result4:N1}");
            Console.WriteLine(avarageResult);



            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
