using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Please, enter some year, so I can figure out is it leap year.");
            year = int.Parse(Console.ReadLine());
            if (year % 400 == 0 )
            {
                Console.WriteLine("Year {0} is a leap year!", year);
            }
            else if (year % 4 == 0 && year / 100 != 0)
            {
                Console.WriteLine("That is correct, year {0} is leap year", year);
            }
            else
            {
                Console.WriteLine("Year {0} is not a leap year.", year);
            }
        }
    }
}
