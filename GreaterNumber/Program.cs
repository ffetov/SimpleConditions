using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (a>=b)
            {
                Console.WriteLine("Greater number:{0}",a);
            }
            else
            {
                Console.WriteLine("Greater number:{0}",b);
            }
        }
    }
}
