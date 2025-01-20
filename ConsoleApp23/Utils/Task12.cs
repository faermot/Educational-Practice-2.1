using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task12 : IPrintOfSolution
    {
        double y, t;

        public Task12(double y, double t)
        {
            this.y = y;
            this.t = t;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"R = {(Math.Sin(Math.Pow((2 * t + 1), 2)) + 0.3) / Math.Log(t + y)}");
        }
    }
}
