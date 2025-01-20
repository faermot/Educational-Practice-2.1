using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task26 : IPrintOfSolution
    {
        double u, y;

        public Task26(double u, double y)
        {
            this.u = u;
            this.y = y;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"T = {(Math.Sin(2 * u)) / (Math.Log(2 * y + u))}");
        }
    }
}
