using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Give number: ");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                case 1: Console.WriteLine("Your number is Zero");
                    break;
                case 2:
                case 3: Console.WriteLine("Your number is One");
                    break;
                case 4:
                case 5: Console.WriteLine("Your number is Two");
                    break;
                case 6:
                case 7: Console.WriteLine("Your number is Three");
                    break;
                case 8:
                case 9: Console.WriteLine("Your number is Four");
                    break;
                case 10:
                case 11:
                case 12: Console.WriteLine("Yournumber is Five");
                    break;
                default: Console.WriteLine("What can I do?");
                    break;
            }
        }
    }
}
