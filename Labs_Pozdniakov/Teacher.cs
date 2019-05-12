using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Teacher:Person
    {
        public string Experience { get; set; }
        public string Position { get; set; }
        public Teacher(string name, int year, int mounth, int day, string faculty, int today_year, int today_mounth, int today_day, string position, string experience)
      : base(name, year, mounth, day, faculty, today_year, today_mounth, today_day)
        {
            Position = position;
            Experience = experience;
        }
        public override void Display()
        {
            Console.WriteLine("Name: " + Name + "\n" + "Faculty: " + Faculty + "\n"+"Position: "+Position +"\n" + "Experience: " + Experience + "\n" + "Age: " + Age+"\n");
        }
    }
}
