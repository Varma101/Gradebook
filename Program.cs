using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("V's B");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(100.2);

            
            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            var avgGrade = 0.0; //var to store avg grade in

            foreach(var number in grades) //loop thru list
            {
                avgGrade += number; //add all of list into avg var
            }
            avgGrade /= grades.Count; //divide avg var by list size to get avg

            Console.WriteLine($"The average grade is {avgGrade:N1} and {book.averageGrade()}");
            book.printGrades();

        }
    }
}
