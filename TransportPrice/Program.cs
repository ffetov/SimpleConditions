using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var DayNight = Console.ReadLine().ToLower();
            var price = 0.0;
            if (DayNight=="day" && n<20)
            {
                price = 0.7 + 0.79 * n;
            }
            else if (DayNight=="night" && n>0 && n<20)
            {
                price = 0.7 + 0.9 * n;
            }
            else if (n>=20 && n<100)
            {
                price = 0.09 * n;
            }
            else
            {
                price = 0.06 * n;
            }
            Console.WriteLine("{0:f2}",price);
        }
    }
}
