using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task13 : IPrintOfSolution
    {
        double y, e, h;

        public Task13(double y, double e, double h)
        {
            this.y = y;
            this.e = e;
            this.h = h;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"A = {(Math.Sin(2 * y + h) + Math.Pow(h, 2)) / (Math.Pow(e, h) + y)}");
        }
    }
}
