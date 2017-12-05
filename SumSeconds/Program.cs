using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());
            var sum=0.0;
            var minutes = 0;
            if (time1>=1 && time1<=50)
            {
                if (time2 > 1 && time2 <= 50)
                {
                    if (time3 > 1 && time3 <= 50)
                    {
                        sum = time1 + time2 + time3;
                    }
                }
            }
            if (sum>=60 && sum<120)
            {
                minutes++;
                sum = sum - 60;
            }
            else if (sum>=120)
            {
                minutes = 2;
                sum = sum - 120;
            }
            if (sum>=10)          
            {
                    Console.WriteLine(minutes + ":" + sum);
            }
            else
            {
                Console.WriteLine(minutes+ ":0" + sum);
            }
        }
    }
}
