using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var waterfilled = h*(p1+p2);
            if (waterfilled>v)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters.",h,waterfilled-v);
            }
            else
            {
                var poolPrecent = Math.Floor((waterfilled / v) * 100);
                var pipe1Precent = Math.Floor((h*p1 / waterfilled) * 100);
                var pipe2Precent = Math.Floor((h*p2 / waterfilled) * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",poolPrecent,pipe1Precent,pipe2Precent);
            }
        }
    }
}
