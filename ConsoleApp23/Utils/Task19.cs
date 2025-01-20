using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task19 : IPrintOfSolution
    {
        double y, q;

        public Task19(double y, double q)
        {
            this.y = y;
            this.q = q;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"E = {(Math.Log(0.7 * y + 2 * q)) / Math.Sqrt((3 * Math.Pow(y, 2) + 0.5 * y + 4))}");
        }
    }
}
