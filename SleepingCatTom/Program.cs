using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepingCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            var hollidays = int.Parse(Console.ReadLine());
            var totalTime = hollidays * 127 + (365 - hollidays) * 63;
            var difference = Math.Abs(30000 - totalTime);
            var hours =difference / 60;
            var minutes = difference - (hours * 60);
            if (totalTime<=30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
