using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine("What month were you born in");
            var month = Console.ReadLine();

            Console.WriteLine("What do you do in your freem time?");
            var sport = Console.ReadLine();


            Console.WriteLine("Your name is:  " + (name));
            Console.WriteLine("Your age is:  " + (age));
            Console.WriteLine("You were born in:  " + (month));
            Console.WriteLine("You enjoy   " +sport + "in your free time" );


            if (month == "September") // Zodiac signs
            {
                Console.WriteLine("Your zodiac sign is Virgo");
            }

            if (month == "January")
            {
                Console.WriteLine("Your zodiac sign is Capricorn");
            }
        }
    }
}
