using System;
using System.Collections.Generic;
using System.Linq;

//purpose of this class is to store a singluar student's grades.

namespace GradeBook
{

    public class Book
    {
        
        public Book(string name)
        {
            bookList = new List<double>();
            this.name = name; // "this" designates the object member not the argument passed
        }
        
        private List<double> bookList; // list of all grades for a student, private

        private string name;        
        
        public void AddGrade(double usrGrade) // function to add grade to booklist
        {
            if(usrGrade <= 100.0) { bookList.Add(usrGrade); } // check to see if grade is at or less than 100

            else { System.Console.WriteLine($"Can't add grade {usrGrade}, greater than 100"); } // throws out error in console and doesn't add it to list
        }

        public void printGrades() // goes thru all grades for a student and prints them out
        {
            foreach(double i in bookList)
            {
                Console.Write($"{i} "); // prints out all grades for a student on the same line
            }
        }

        public double averageGrade() { return bookList.Average(); } //gives an average of all the grades for a student

        public void removeGrade(double gradeToRemove, bool removalCheck = false)
        {
            bookList.Remove(gradeToRemove);

            if(removalCheck == true)
            {
                int nonRemoved = 0;

                foreach(double i in bookList)
                {
                    if(i == gradeToRemove)
                    {
                        nonRemoved += 1;
                    }
                }

                System.Console.WriteLine($"There are {nonRemoved} instances still remaining");
            }
        }




    }
    
}