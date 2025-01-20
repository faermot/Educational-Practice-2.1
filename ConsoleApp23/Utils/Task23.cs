using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task23 : IPrintOfSolution
    {

        double y, e, d;

        public Task23(double y, double e, double d)
        {
            this.y = y;
            this.e = e;
            this.d = d;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"R = {(Math.Sin(Math.Pow(y, 2) + 0.3 * d)) / (Math.Pow(e, y) + Math.Log(d))}");
        }
    }
}
