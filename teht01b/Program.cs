using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht01b
{
    class Program
    {
        static void Main(string[] args)
        {  // ask number
            int num;
            Console.Write("Give a number: ");
            string line = Console.ReadLine();
            bool result = Int32.TryParse(line, out num);
            if (result == true)
            {
                // Show number "text"
                switch (num)
                {
                    case 1: Console.WriteLine("One"); break;
                    case 2: Console.WriteLine("Two"); break;
                    case 3: Console.WriteLine("Three"); break;
                    default: Console.WriteLine("Some another number"); break;
                }
            }
            else
            {
                Console.WriteLine("Not a integer value!");
            }

        }
    }
}
