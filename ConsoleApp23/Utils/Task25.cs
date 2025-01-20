using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task25 : IPrintOfSolution
    {
        double c, t;

        public Task25(double c, double t)
        {
            this.c = c;
            this.t = t;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"L = {Math.Cos(Math.Pow(c, 2)) + (3 * Math.Pow(t, 3) + 3) / Math.Sqrt(c + t)}");
        }
    }
}

