using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task14 : IPrintOfSolution
    {
        double y, e, h;

        public Task14(double y, double e, double h)
        {
            this.y = y;
            this.e = e;
            this.h = h;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"P = {Math.Pow(e, (y + 2.5) + Math.Pow((7.1 * h), 2)) / (Math.Log(Math.Sqrt(y + 0.04 * h)))}");
        }
    }
}
