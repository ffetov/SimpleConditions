using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            var placesForRow =Math.Floor((h-1)/0.70);
            var row = Math.Floor(w/1.2);
            var places = placesForRow * row - 3;
            Console.WriteLine(places);
        }
    }
}
