using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task3 : IPrintOfSolution
    {
        double e, y, k;

        public Task3(double e, double y, double k)
        {
            this.e = e;
            this.y = y;
            this.k = k;
        }

        public void PrintSolution()
        {
            Console.WriteLine($"U = {(Math.Log(k - y) + Math.Pow(y, 4)) / (Math.Pow(e, y) + 2.355 * k)}");
        }
    }
}
