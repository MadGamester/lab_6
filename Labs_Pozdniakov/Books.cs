using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    abstract class Books
    {

       
        public string Author { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public int Year_of_publishing { get; set; }
        public int Number_of_pages { get; set; }
        public Books(string author, string name, int id, int year, int number)
        {
            Author = author;
            Name = name;
            ID = id;
            Year_of_publishing = year;
            Number_of_pages = number;
        }
        
    }
}
