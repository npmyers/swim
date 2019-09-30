using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input  avalue of t:");

            double t = Double.Parse(Console.ReadLine());

            Console.WriteLine("input value of x :");

            double x = Double.Parse(Console.ReadLine());

            double y;

            Console.WriteLine("input value for n:");

            double n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input value for m:");

            double m = Int32.Parse(Console.ReadLine());


            y = Math.Exp(-t) * ((Math.Sin((n * x * Math.PI) / 2)) + (Math.Sin((m * x * Math.PI) / 2)));

            Console.WriteLine(y);





        }
    }
}
