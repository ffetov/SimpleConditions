using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            if (hours >= 0 && hours < 24)
            {
                if (minutes >=0 && minutes <60)
                {
                    minutes += 15;
                    if (minutes > 59)
                    {
                        hours++;
                        minutes = minutes - 60;
                    }
                }
            }
            if (hours==24)
            {
                hours = 0;
            }
            if (minutes<10)
            {
                Console.WriteLine(hours + ":0" + minutes);
            }
            else
            {
                Console.WriteLine(hours + ":" + minutes);
            }
        }
    }
}
