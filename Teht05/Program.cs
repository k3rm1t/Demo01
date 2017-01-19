using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec, min, hour, left;
            Console.WriteLine("Give me some seconds so I can show you some magic!");
            sec = int.Parse(Console.ReadLine());
            hour = sec / 3600;
            min = sec / 60 - hour * 60 ;
            left = sec % 60;
            Console.WriteLine("You gave {0} seconds, and it is {1} hour, {2} minutes and {3} seconds" ,sec, hour, min, left);
        }
    }
}
