using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Tell me, how old are you?");
            age = int.Parse(Console.ReadLine());
            if (age < 18)
                Console.WriteLine("You are under age! Please play nicely!");
            else if (age == 18 && age <= 65)
                Console.WriteLine("You are adult! Great, you can buy bear in Finland!!");
            else
                Console.WriteLine("You are Senior, hope you are not angry...");
        }
    }
}
