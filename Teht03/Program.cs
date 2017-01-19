using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Give me number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give third number");
            num3 = int.Parse(Console.ReadLine());
            int sub = num1 + num2 + num3;
            Console.WriteLine("Sum is: {0}", sub);
            double answer = sub / 3.0;
            Console.WriteLine("Keskiarvo: {0}", answer);

        }
    }
}
