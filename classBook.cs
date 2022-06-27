using System.Collections.Generic;

namespace GradeBook
{
    public class classBook // a list of gradeBooks, with every gradebook being 1 student. represents 1 classroom each
    {
    
        public classBook(string className) //constructor, requires a string with the classroom's name
        {

            studList = new List<Book>();
            this.name = className;
            
        }

        List<Book> studList;

        public void addStud(Book book)
        {
            studList.Add(book);
        }

        private string name;

    }
}