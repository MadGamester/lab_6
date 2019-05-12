﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Poems : Books
    {
        public string Ganre { get; }
        public Poems(string author, string name, int id, int year, int number)
        : base(author, name, id, year, number)
        {
            Ganre = "Poems";
        }
        public override string ToString()
        {
            return "Author: " + Author + "\n" + "Name: " + Name + "\n" + "ID: " + ID + "\n" + "Year of publishing: " + Year_of_publishing + "\n" + "Number of pages: " + Number_of_pages + "\n" + "Ganre: " + Ganre + "\n";

        }
    }
}
