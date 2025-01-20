using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task10 : IPrintOfSolution
    {
        double y, t;

        public Task10(double y, double t)
        {
            this.y = y;
            this.t = t;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"Z = {(2 * t + y * Math.Cos(t)) / (Math.Sqrt(y + 4.831))}");
        }
    }
}
