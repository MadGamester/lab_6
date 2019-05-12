using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string Faculty { get; set; }
        public int Today_year { get; set; }
        public int Today_month { get; set; }
        public int Today_day { get; set; }
        public Person(string name, int year, int month, int day, string faculty, int today_year, int today_month, int today_day)
        {
            Name = name;
            Year = year;
            Month = month;
            Day = day;
            Faculty = faculty;
            Today_year = today_year;
            Today_month = today_month;
            Today_day = today_day;
        }
        public abstract void Display();
        public  int Age
        {
            get
            {
                int age = 0;
                age = ((Today_year * 365 + Today_month * 30 + Today_day) - (Year * 365 + Month * 30 + Day)) / 365;
                return age;
            }
        }
    }
}
