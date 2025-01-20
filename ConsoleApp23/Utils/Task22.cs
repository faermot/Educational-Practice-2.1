using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    internal class Task22 : IPrintOfSolution
    {
        double y, t;

        public Task22(double y, double t)
        {
            this.y = y;
            this.t = t;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"S = {(4.351 * Math.Pow(y, 3) + 2 * t * Math.Log(t)) / (Math.Sqrt(Math.Cos(2 * y) + 4.351))}");
        }
    }
}
