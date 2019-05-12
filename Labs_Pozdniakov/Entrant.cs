using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Entrant:Person
    {
        public Entrant(string name, int year, int month, int day, string faculty, int today_year, int today_month, int today_day)
        : base(name, year,month,day, faculty,today_year,today_month, today_day){}
        public override void Display()
        {
            Console.WriteLine("Name: "+Name+"\n"+"Faculty: "+Faculty+"\n"+"Age: "+Age+"\n");
        }
    }
}
