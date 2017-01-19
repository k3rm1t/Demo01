using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You can give me some random numbers and I count for you.\nIf you want to stop give zero(0) and press enter.");
            int i, j = 0 ;
            do
            {
                i = int.Parse(Console.ReadLine());
                j = i + j ;
                //Console.WriteLine("Counting : {0}", j);
            }
            while (i != 0);
            Console.WriteLine("The final is {0}", j);
                        
 
        }
    }
}
