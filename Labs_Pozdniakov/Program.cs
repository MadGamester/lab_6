using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Program
    {
       static  Entrant entrant_1 = new Entrant("0", 0, 0, 0, "0", 0, 0, 0);
       static Student student_1 = new Student("0", 0, 0, 0, "0", 0, 0, 0);
       static Teacher teacher_1 = new Teacher("0", 0, 0, 0, "0", 0, 0, 0, "0", "0");
       static Comedy comedy_1 = new Comedy("Dante", "Divine comedy", 1, 1320, 1000);
       static Poems poems_1 = new Poems("Shevchenko", "Caucasus", 2, 1830, 320);
       static Roman roman_1 = new Roman("Bulgakov", "The Master and Margarita", 3, 1960, 900);
       static Tale tale_1 = new Tale("Andersen", "Ugly duck", 4, 1860, 100);
       static Drama drama_1 = new Drama("Shakespeare", "Romeo & Juliet", 5, 1597, 830);


        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            End();
        }
       public static void Task_1()
        {
            int number;
            string input;
            bool error;

            Console.WriteLine("Enter today year: ");
            input = Console.ReadLine();
            error = int.TryParse(input, out number);
            if (error != true)
            {
                Console.WriteLine("Incorect input! Value = 1");
                entrant_1.Today_year = 1;
                student_1.Today_year = 1;
                teacher_1.Today_year = 1;
            }
            else
            {
                entrant_1.Today_year = number;
                student_1.Today_year = number;
                teacher_1.Today_year = number;
            }
            Console.WriteLine();
            Console.WriteLine("Enter today month: ");
            input = Console.ReadLine();
            error = int.TryParse(input, out number);
            if (error != true)
            {
                Console.WriteLine("Incorect input! Value = 1");
                entrant_1.Today_month = 1;
                student_1.Today_month = 1;
                teacher_1.Today_month = 1;
            }
            else
            {
                entrant_1.Today_month = number;
                student_1.Today_month = number;
                teacher_1.Today_month = number;
            }
            Console.WriteLine();

            Console.WriteLine("Enter today day: ");
            input = Console.ReadLine();
            error = int.TryParse(input, out number);
            if (error != true)
            {
                Console.WriteLine("Incorect input! Value = 1");
                entrant_1.Today_day = 1;
                student_1.Today_day = 1;
                teacher_1.Today_day = 1;
            }
            else
            {
                entrant_1.Today_day = number;
                student_1.Today_day = number;
                teacher_1.Today_day = number;
            }
            Console.WriteLine();

            Console.WriteLine("Okay! Let`s add some information about entant, student, teacher.");
            Console.WriteLine();

            Console.WriteLine("Enter entrant name: ");
            input = Console.ReadLine();
            entrant_1.Name = input;
            Console.WriteLine();

            Console.WriteLine("Enter entrant faculty: ");
            input = Console.ReadLine();
            entrant_1.Faculty = input;
            Console.WriteLine();

            Console.WriteLine("Enter entrant year of birth: ");
            input = Console.ReadLine();
            error = int.TryParse(input,out  number);
            if (error != true)
            {
                Console.WriteLine("Incorect input! Value = 1");
                entrant_1.Year = 1;
            }
            else entrant_1.Year = number;
            Console.WriteLine();

            Console.WriteLine("Enter entrant month of birth: ");
            input = Console.ReadLine();
            error = int.TryParse(input, out number);
            if (error != true)
            {
                Console.WriteLine("Incorect input! Value = 1");
                entrant_1.Month = 1;
            }
            else entrant_1.Month = number;
            Console.WriteLine();

            Console.WriteLine("Enter entrant day of birth: ");
            input = Console.ReadLine();
            error = int.TryParse(input, out number);
            if (error != true)
            {
                Console.WriteLine("Incorect input! Value = 1");
                entrant_1.Day = 1;
            }
            else entrant_1.Day = number;
            Console.WriteLine();

            ////////////////////////////////////////////////////////////////////

            Console.WriteLine("Enter student name: ");
            input = Console.ReadLine();
            student_1.Name = input;
            Console.WriteLine();

            Console.WriteLine("Enter student faculty: ");
            input = Console.ReadLine();
            student_1.Faculty = input;
            Console.WriteLine();

            Console.WriteLine("Enter student year of birth: ");
            input = Console.ReadLine();
            error = int.TryParse(input, out number);
            if (error != true)
            {
                Console.WriteLine("Incorect input! Value = 1");
                student_1.Year = 1;
            }
            else student_1.Year = number;
            Console.WriteLine();

            Console.WriteLine("Enter student month of birth: ");
            input = Console.ReadLine();
            error = int.TryParse(input, out number);
            if (error != true)
            {
                Console.WriteLine("Incorect input! Value = 1");
                student_1.Month = 1;
            }
            else student_1.Month = number;
            Console.WriteLine();

            Console.WriteLine("Enter student day of birth: ");
            input = Console.ReadLine();
            error = int.TryParse(input, out number);
            if (error != true)
            {
                Console.WriteLine("Incorect input! Value = 1");
                student_1.Day = 1;
            }
            else student_1.Day = number;
            Console.WriteLine();

            /////////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter teacher name: ");
            input = Console.ReadLine();
            teacher_1.Name = input;
            Console.WriteLine();

            Console.WriteLine("Enter teacher faculty: ");
            input = Console.ReadLine();
            teacher_1.Faculty = input;
            Console.WriteLine();

            Console.WriteLine("Enter teacher year of birth: ");
            input = Console.ReadLine();
            error = int.TryParse(input, out number);
            if (error != true)
            {
                Console.WriteLine("Incorect input! Value = 1");
                teacher_1.Year = 1;
            }
            else teacher_1.Year = number;
            Console.WriteLine();

            Console.WriteLine("Enter teacher month of birth: ");
            input = Console.ReadLine();
            error = int.TryParse(input, out number);
            if (error != true)
            {
                Console.WriteLine("Incorect input! Value = 1");
                teacher_1.Month = 1;
            }
            else teacher_1.Month = number;
            Console.WriteLine();

            Console.WriteLine("Enter teacher day of birth: ");
            input = Console.ReadLine();
            error = int.TryParse(input, out number);
            if (error != true)
            {
                Console.WriteLine("Incorect input! Value = 1");
                teacher_1.Day = 1;
            }
            else teacher_1.Day = number;
            Console.WriteLine();

            Console.WriteLine("Enter teacher position : ");
            input = Console.ReadLine();
            teacher_1.Position = input;
            Console.WriteLine();

            Console.WriteLine("Enter teacher expirience: ");
            input = Console.ReadLine();
            teacher_1.Experience = input;
            Console.WriteLine();

            //////////////////////////////////////////////////////////////////////
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("\n\n");
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("Information about entrant: ");
            Console.WriteLine();
            entrant_1.Display();
            Console.WriteLine("\n\n");
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("Information about student: ");
            Console.WriteLine();
            student_1.Display();
            Console.WriteLine("\n\n");
            Console.WriteLine("____________________________________________________________________________");
            Console.WriteLine("Information about teacher: ");
            Console.WriteLine();
            teacher_1.Display();
            
        }
       public static void Task_2()
        {
            Console.WriteLine("Information about books: ");
            Console.WriteLine("First* \n\n"+comedy_1.ToString()); 
            Console.WriteLine("Second** \n\n"+drama_1.ToString());
            Console.WriteLine("Third*** \n\n"+poems_1.ToString());
            Console.WriteLine("Fourth**** \n\n"+roman_1.ToString());
            Console.WriteLine("Fifth***** \n\n"+tale_1.ToString());
            Console.WriteLine("Let`s compare some books! Choose first book for compare(1-5): ");
            Console.WriteLine("1)Divine comedy ");
            Console.WriteLine("2)Caucasus ");
            Console.WriteLine("3)The Master and Margarita ");
            Console.WriteLine("4)Ugly duck ");
            Console.WriteLine("5)Romeo & Juliet ");
            int first;
            string input;
            bool error;
            input = Console.ReadLine();
            error = int.TryParse(input, out first);
            if (error != true || (first > 5 || first < 1))
            {
                Console.WriteLine("Incorect input! Value = 1");
                first = 1;
            }
            Console.WriteLine("Choose second book for compare (1-5)");
            Console.WriteLine("1)Divine comedy ");
            Console.WriteLine("2)Caucasus ");
            Console.WriteLine("3)The Master and Margarita ");
            Console.WriteLine("4)Ugly duck ");
            Console.WriteLine("5)Romeo & Juliet ");
            int second = 0;
            input = Console.ReadLine();
            error = int.TryParse(input, out second);
            if (error != true || (second > 5 || second < 1))
            {
                Console.WriteLine("Incorect input! Value = 2");
                second = 2;
            }
            Console.WriteLine("Choose params for compare(1-2)");
            Console.WriteLine("1) Number of pages;");
            Console.WriteLine("2)Year of Publishing");
            int number = 0;
            input = Console.ReadLine();
            error = int.TryParse(input, out number);
            if (error != true||(number>2||number<1))
            {
                Console.WriteLine("Incorect input! Value = 1");
                number = 1;
            }

            if( number==1)
            {
                if(comedy_1.ID==first||comedy_1.ID==second)
                {
                    Console.WriteLine("Name: "+comedy_1.Name);
                    Console.WriteLine("Number of pages: "+comedy_1.Number_of_pages);
                }
                if (drama_1.ID == first || drama_1.ID == second)
                {
                    Console.WriteLine("Name: " + drama_1.Name);
                    Console.WriteLine("Number of pages: " + drama_1.Number_of_pages);
                }
                if (poems_1.ID == first || poems_1.ID == second)
                {
                    Console.WriteLine("Name: " + poems_1.Name);
                    Console.WriteLine("Number of pages: " + poems_1.Number_of_pages);
                }
                if (roman_1.ID == first || roman_1.ID == second)
                {
                    Console.WriteLine("Name: " + roman_1.Name);
                    Console.WriteLine("Number of pages: " + roman_1.Number_of_pages);
                }
                if (tale_1.ID == first || tale_1.ID == second)
                {
                    Console.WriteLine("Name: " + tale_1.Name);
                    Console.WriteLine("Number of pages: " + tale_1.Number_of_pages);
                }
            }
            if (number == 2)
            {
                if (comedy_1.ID == first || comedy_1.ID == second)
                {
                    Console.WriteLine("Name: " + comedy_1.Name);
                    Console.WriteLine("Year of Publishing: " + comedy_1.Number_of_pages);
                }
                if (drama_1.ID == first || drama_1.ID == second)
                {
                    Console.WriteLine("Name: " + drama_1.Name);
                    Console.WriteLine("Year of Publishing: " + drama_1.Number_of_pages);
                }
                if (poems_1.ID == first || poems_1.ID == second)
                {
                    Console.WriteLine("Name: " + poems_1.Name);
                    Console.WriteLine("Year of Publishing: " + poems_1.Number_of_pages);
                }
                if (roman_1.ID == first || roman_1.ID == second)
                {
                    Console.WriteLine("Name: " + roman_1.Name);
                    Console.WriteLine("Year of Publishing: " + roman_1.Number_of_pages);
                }
                if (tale_1.ID == first || tale_1.ID == second)
                {
                    Console.WriteLine("Name: " + tale_1.Name);
                    Console.WriteLine("Year of Publishing: " + tale_1.Number_of_pages);
                }
            }
            Console.WriteLine("\n\nLet`s find book in our library!Enter books id(1-5):\n ");
           
            input = Console.ReadLine();
            error = int.TryParse(input, out number);
            if (error != true||(number>5||number<1))
            {
                Console.WriteLine("Incorect input! Value = 1");
                number = 1;
            }
            Console.WriteLine("Book with ID "+number+":\n");
            if (comedy_1.ID == number )
            {
                Console.WriteLine(comedy_1.ToString());
            }
            if (drama_1.ID == number)
            {
                Console.WriteLine(drama_1.ToString());
            }
            if (poems_1.ID == number)
            {
                Console.WriteLine(poems_1.ToString());
            }
            if (roman_1.ID == number)
            {
                Console.WriteLine(roman_1.ToString());
            }
            if (tale_1.ID == number)
            {
                Console.WriteLine(tale_1.ToString());
            }





        }
       public static void End()
        {
            Console.WriteLine("\n\n\n"+"\t\t\tProgram end! Enter any key...");
            Console.Read();
        }
    }
}
