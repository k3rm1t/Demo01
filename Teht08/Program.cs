using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I figure out the biggest number!\nPress enter after every number.");
            Console.WriteLine("Give me number one ->");
            int one = int.Parse(Console.ReadLine());
            Console.WriteLine("And number two ->");
            int two = int.Parse(Console.ReadLine());
            Console.WriteLine("And number three ->");
            int three = int.Parse(Console.ReadLine());

            if (one < two && one < three)
            {
                if (two > one && two > three)
                {
                    Console.WriteLine("The number {0} is biggest", two);
                }
                else if (three > one && three > two)
                {
                    Console.WriteLine("The number {0} is biggest", three);
                }
            }
            else Console.WriteLine("Number {0} is biggest", one);
        }
    }
}
